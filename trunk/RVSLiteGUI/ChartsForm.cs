using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SerialConnection;

namespace RVSLite{
    public partial class ChartsForm : Form{
        const int AXES_SHIFT = 600;
        const int AXES_SPAN = 50;
        private readonly List<Color> _colorsList;
        private readonly Dictionary<int, DataHolder> _dataHolders;
        private readonly Graphics _g;
        private readonly TerminalController _terminalController;
        private readonly Pen _gridPen;
        private bool _stopControls;
        private string _startSymbol = "S";
        private string _deviderSymbol = ";";
        private string _finishSymbol = "F";
        private int _x;

        public ChartsForm(TerminalController terminalController){
            _terminalController = terminalController;
            InitializeComponent();
            lstDataHolders.DisplayMember = "Name";
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            _g = Graphics.FromImage(pictureBox.Image);
            _dataHolders = new Dictionary<int, DataHolder>();
            _colorsList = InitColorsList();
            _gridPen = new Pen(new SolidBrush(Color.Gray));
            Bind();
            DrawAxes(0, pictureBox.Width);
            RefreshStartStopButton();
            RefreshMeasureFreqLabel();
        }

        private void Bind(){
            Closing += ChartsForm_Closing;
            _terminalController.OnAnswerReceived += GotAnswer;
            _terminalController.OnDisconnected += Disconnected;
        }

        private void Disconnected(SerialConnectionBase source){
            Stop();
        }

        private void ChartsForm_Closing(object sender, CancelEventArgs e){
            Unbind();
        }

        private void Unbind(){
            _terminalController.OnAnswerReceived -= GotAnswer;
        }

        private void GotAnswer(SerialConnectionBase source){
            if (!timer1.Enabled)
                return;
            string lines = source.LastReadLines;
            if (!Regex.IsMatch(lines, string.Format(@"{0}[\-\d{1}]+{2}",
                                                    GetCorrectSymbolBy(_startSymbol),
                                                    GetCorrectSymbolBy(_deviderSymbol),
                                                    GetCorrectSymbolBy(_finishSymbol))))
                return;
            var values = CollectParameters(source);
            StoreParameters(values);
        }

        private static string GetCorrectSymbolBy(string symbol){
            return symbol == @"\"? @"\\":symbol;
        }

        private void StoreParameters(IList<int> values){
            if(values.Count == numMaxParameters.Value){
                for (int i = 0; i < values.Count; i++){
                    if (_dataHolders.Count < i + 1)
                        AddParameter();
                    _dataHolders[i].Value = values[i];
                }
            }
        }

        private static List<int> CollectParameters(SerialConnectionBase source){
            string[] strings = Regex.Split(source.LastReadLines, "[;\r\n]");
            var values = new List<int>();
            foreach (string line in strings){
                int intValue;
                if (!int.TryParse(line, out intValue))
                    continue;
                values.Add(intValue);
            }
            return values;
        }

        private static List<Color> InitColorsList(){
            return new List<Color>{
                                      Color.White,
                                      Color.Yellow,
                                      Color.Green,
                                      Color.Magenta,
                                      Color.Red,
                                      Color.Blue,
                                      Color.BlueViolet,
                                      Color.Brown,
                                      Color.DeepPink,
                                      Color.Orange,
                                      Color.DarkGreen,
                                      Color.Pink,
                                  };
        }

        private void AddParameter(){
            string name = _dataHolders.Count.ToString();
            var dataHolder = new DataHolder(GetColorBy(_dataHolders.Count), name);
            _dataHolders.Add(_dataHolders.Count, dataHolder);
            SetDefaultShiftFor(dataHolder);
        }

        private void SetDefaultShiftFor(DataHolder dataHolder){
            var shift = AXES_SPAN * _dataHolders.Count;
            if (shift < AXES_SHIFT)
                dataHolder.Shift = shift;
        }

        private Color GetColorBy(int index){
            return index > _colorsList.Count - 1 ? Color.Black : _colorsList[index];
        }

        private void timer1_Tick(object sender, EventArgs e){
            DrawChartTick(AXES_SHIFT);
        }

        private void DrawChartTick(int AxesShift){
            var bitmap = new Bitmap(pictureBox.Image);
            var maxX = (pictureBox.Width - 2);
            if (_x >= maxX) {
                _g.Clear(BackColor);
                _g.DrawImage(bitmap, -2, 0);
                DrawAxes(_x, _x + 2);
            }
            else{
                _x += 2;
                if (_x >= maxX)
                    _x = maxX;
            }
            foreach (DataHolder dataHolder in _dataHolders.Values){
                if(!dataHolder.Enabled)
                    continue;
                _g.DrawLine(dataHolder.Pen, _x, AxesShift - dataHolder.ScaledValue, _x + 2, AxesShift - dataHolder.PrevScaledValue);
                dataHolder.StoreValue();
                if (SelectedDataHolder == dataHolder)
                    UpdateValueControl(dataHolder);
            }
            pictureBox.Refresh();
            SyncList();
        }

        private void DrawAxes(int x1, int x2){
            for (int i = AXES_SHIFT - AXES_SPAN; i > 0; i -= AXES_SPAN)
                _g.DrawLine(_gridPen, x1, i, x2, i);
        }

        private void SyncList(){
            if (lstDataHolders.Items.Count < _dataHolders.Count){
                for (int i = lstDataHolders.Items.Count; i < _dataHolders.Count; i++) {
                    lstDataHolders.Items.Add(_dataHolders[i]);
                    lstDataHolders.SetItemChecked(lstDataHolders.Items.Count - 1, true);
                }
                if (lstDataHolders.SelectedItem == null && lstDataHolders.Items.Count > 0)
                    lstDataHolders.SelectedIndex = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e){
            if (timer1.Enabled)
                Stop();
            else
                Start();
        }

        private void Start(){
            timer1.Start();
            RefreshStartStopButton();
        }

        private void Stop(){
            timer1.Stop();
            RefreshStartStopButton();
        }

        private void RefreshStartStopButton(){
            btnStart.Text = timer1.Enabled ? "Stop" : "Start";
        }

        private DataHolder SelectedDataHolder { get; set; }

        private void InitControlsBy(DataHolder dataHolder){
            _stopControls = true;
            numRate.Value = dataHolder.Rate;
            trkShift.Value = dataHolder.Shift / AXES_SPAN;
            txtName.Text = dataHolder.Name;
            pnlColor.BackColor = dataHolder.Color;
            UpdateValueControl(dataHolder);
            RefreshLabels();
            _stopControls = false;
        }

        private void UpdateValueControl(DataHolder dataHolder){
            txtValue.Text = dataHolder.Value.ToString();
        }

        private void trkShift_Scroll(object sender, EventArgs e){
            if (_stopControls || SelectedDataHolder == null)
                return;
            SelectedDataHolder.Shift = trkShift.Value * AXES_SPAN;
            RefreshLabels();
        }

        private void RefreshLabels(){
            lblShift.Text = string.Format("Shift: {0}", trkShift.Value * AXES_SPAN);
        }

        private void trkFreq_Scroll(object sender, EventArgs e){
            timer1.Stop();
            timer1.Interval = trkFreq.Value * 10;
            timer1.Start();
            RefreshMeasureFreqLabel();
        }

        private void RefreshMeasureFreqLabel(){
            lblMeasureFrequency.Text = string.Format("Freq.: {0} ms", trkFreq.Value * 10);
        }

        #region Nested type: DataHolder

        public class DataHolder{
            private int _rate;

            public DataHolder(Color color, string name){
                Pen = new Pen(new SolidBrush(color), 2);
                Name = name;
                Rate = 1;
                Enabled = true;
            }

            public string Name { get; set; }

            public Pen Pen { get; set; }

            public float Value { get; set; }

            public float PrevScaledValue { get; private set; }

            public int Rate{
                get { return _rate; }
                set { _rate = value < 1 ? 1 : value; }
            }

            public int Shift { get; set; }

            public Color Color{
                get { return Pen.Color; }
            }

            public bool Enabled { get; set; }

            public int ScaledValue{
                get { return (int) (Value*Rate + Shift); }
            }

            public void StoreValue(){
                PrevScaledValue = ScaledValue;
            }
        }

        #endregion

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (SelectedDataHolder == null)
                return;
            SelectedDataHolder.Name = txtName.Text;
            lstDataHolders.Refresh();
        }

        private void lstDataHolders_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstDataHolders.Items.Count == 0 || lstDataHolders.SelectedItem == null)
                return;
            SelectedDataHolder = ((DataHolder)lstDataHolders.SelectedItem);
            InitControlsBy(SelectedDataHolder);
        }

        private void lstDataHolders_ItemCheck(object sender, ItemCheckEventArgs e) {
            var checkedListBox = ((CheckedListBox)sender);
            ((DataHolder) checkedListBox.Items[e.Index]).Enabled = (e.NewValue == CheckState.Checked);
        }

        private void btnUpdateFormat_Click(object sender, EventArgs e) {
            _startSymbol = txtStartSymbol.Text;
            _deviderSymbol = txtDevSymbol.Text;
            _finishSymbol = txtFinishSymbol.Text;
        }

        private void numRate_ValueChanged(object sender, EventArgs e){
            ChangeRate();
        }

        private void ChangeRate(){
            if (_stopControls || SelectedDataHolder == null)
                return;
            SelectedDataHolder.Rate = (int)numRate.Value;
            RefreshLabels();
        }

        private void trkProp_Scroll(object sender, EventArgs e) {
            AutoSendDataPID();
        }

        private void trkIntegr_Scroll(object sender, EventArgs e) {
            AutoSendDataPID();
        }

        private void trkDerivative_Scroll(object sender, EventArgs e) {
            AutoSendDataPID();
        }

        private void AutoSendDataPID(){
            if (!chkAutoSend.Checked)
                return;
            SendDataPID();
        }

        private void SendDataPID(){
            string message = string.Format("S;{0};{1};{2};F;",
                                          Math.Ceiling(GetPIDValueFor(numProp, trkProp)),
                                          GetPIDValueFor(numIntegr, trkIntegr),
                                          Math.Ceiling(GetPIDValueFor(numDeriv, trkDerivative)));
            _terminalController.Connection.WriteLine(message);
            txtSentData.Text = message;
        }

        private static decimal GetPIDValueFor(NumericUpDown numericUpDown, TrackBar trackBar){
            return numericUpDown.Value / trackBar.Maximum * trackBar.Value;
        }

        private void btnSendDataPID_Click(object sender, EventArgs e) {
            SendDataPID();
        }
    }
}