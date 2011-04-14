using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using SerialConnection;

namespace RVSLite{
    public partial class MainForm : Form{
        private readonly ActivityControlsController _activityControlsController;
        private ActivitiesController _activitiesController;
        private TerminalController _terminalController;

        public MainForm(){
            InitializeComponent();
            Lang.SwitchToRu();
            saveFileDialog.InitialDirectory = Preferences.Instance.DefaultDiagramFilesPath;
            _activityControlsController = new ActivityControlsController(designFieldControl);
            CreateActivitiesController();
            _activitiesController.DiagramFileName = string.Format("{0}1.xml", Lang.Res.Diagram);//rdg
            MainController.InitBy(_activitiesController, txtPrompting, tabControl);
            InitBasicActivities();
            terminalToolStripMenuItem.Checked = TerminalPanel.Visible;
            Bind();
            InterfaceLocalization();
        }

        private void CreateActivitiesController(){
            InitPortsList();
            InitBaudList();
            var dataSource = new List<SerialConnectionBase>(){
                                                                 new USB2UARTSerialConnection("NUL", 9600, Parity.None, 8, StopBits.One, Handshake.None, 300, 300),
                                                                 new TelegesisETRX2Connection("NUL", 9600, Parity.None, 8, StopBits.One, Handshake.None, 100, 100),
                                                             };
            cbSerialConnectionProviders.DataSource = dataSource;
            _terminalController = new TerminalController(this, btnConnect, btnSendATCommand, txtATCommand, txtTerminal, cbSerialConnectionProviders, cbPorts, cbBaud);
            _activitiesController = new ActivitiesController(CreateServicesProvider(_terminalController));
        }

        private void InitBaudList(){
            cbBaud.DataSource = GetBaudList();
            cbBaud.SelectedIndex = 3;
        }

        private void InitPortsList(){
            cbPorts.DataSource = SerialPort.GetPortNames();
            if(cbPorts.Items.Count == 0){
                btnConnect.Enabled = false;
                txtTerminal.Text = "Serial ports not found";
            }
            else{
                cbPorts.SelectedIndex = cbPorts.Items.Count - 1;
            }
        }

        private static List<int> GetBaudList(){
            return new List<int>{
                                    1200,
                                    2400,
                                    4800,
                                    9600,
                                    14400,
                                    19200,
                                    28800,
                                    115200
                                };
        }

        private SplitterPanel TerminalPanel{
            get { return splitContainer5.Panel1; }
        }

        private void InterfaceLocalization(){
            fileToolStripMenuItem.Text = Lang.Res.File;
            exitToolStripMenuItem.Text = Lang.Res.Exit;
            communicationToolStripMenuItem.Text = Lang.Res.Communication;
            clearTerminalToolStripMenuItem.Text = Lang.Res.Clear_terminal;
            editToolStripMenuItem.Text = Lang.Res.Edit;
            terminalToolStripMenuItem.Text = Lang.Res.Terminal;
            helpToolStripMenuItem.Text = Lang.Res.Help;
            aboutToolStripMenuItem.Text = Lang.Res.About;
            btnClearTerminal.Text = Lang.Res.Clear;
            btnSendATCommand.Text = Lang.Res.Send_command;
            btnConnect.Text = Lang.Res.Connect;
            btnShowHideTerminalControls.Text = Lang.Res.Terminal_control;
            gbBasicActivities.Text = Lang.Res.Basic_activities;
            gbServices.Text = Lang.Res.Services;
            clearAllToolStripMenuItem.Text = Lang.Res.Clear_all;
            btnShowHidePrompting.Text = Lang.Res.Prompting;
            deleteToolStripMenuItem.Text = Lang.Res.Delete;
            tabMainField.Text = Lang.Res.Diagram;
            openToolStripMenuItem.Text = Lang.Res.Open;
            saveToolStripMenuItem.Text = Lang.Res.Save;
        }

        private ServiceProvider CreateServicesProvider(TerminalController terminalController){
            var serviceProvider = new ServiceProvider();
            var serialConnectionServicesController = new SerialConnectionServicesController(terminalController);
            serviceProvider.BumperPorts = new List<IService>{
                                                                bumperControl1,
                                                                bumperControl2,
                                                                serialConnectionServicesController.Add(new SerialConnectionBumperService("SC " + Lang.Res.Bumper, 1), 0),
                                                                serialConnectionServicesController.Add(new SerialConnectionBumperService("SC " + Lang.Res.Bumper, 2), 1)
                                                            };
            serviceProvider.LEDPorts = new List<IService>{
                                                             ledControl1,
                                                             ledControl2,
                                                             serialConnectionServicesController.Add(new SerialConnectionLEDService("SC" + Lang.Res.LED), 0)
                                                         };
            serviceProvider.DrivePorts = new List<IService>{
                                                               driveControl1, 
                                                               driveControl2,
                                                               serialConnectionServicesController.Add(new SerialConnectionDriveService("SC " + Lang.Res.Drive, 1), 0),
                                                               serialConnectionServicesController.Add(new SerialConnectionDriveService("SC " + Lang.Res.Drive, 2), 1)
                                                           };
            serviceProvider.MessengerPorts = new List<IService>{messengerEmulatorControl1};
            return serviceProvider;
        }

        private void InitBasicActivities(){
            InitActivitiesFor(lvBasicActivities, MainController.Instance.BasicActivities);
            InitActivitiesFor(lvServices, MainController.Instance.Services);
        }

        private void Bind(){
            _activityControlsController.OnActivityControlPlaced += ClearActivityFactorySelection;
            _activityControlsController.OnUnregisterActivity += _activitiesController.UnregisterActivity;
            _activityControlsController.OnRegisterActivity += _activitiesController.RegisterActivity;
            _activityControlsController.OnExpandCompositeActivity += _activityControlsController_OnExpandCompositeActivity;
            lvBasicActivities.SelectedIndexChanged += lvBasicActivities_SelectedIndexChanged;
            lvServices.SelectedIndexChanged += lvBasicActivities_SelectedIndexChanged;
            clearAllToolStripMenuItem.Click += clearAllToolStripMenuItem_Click;
            terminalToolStripMenuItem.Click += terminalToolStripMenuItem_Click;
            btnShowHideTerminalControls.Click += btnShowHideTerminalControls_Click;
            clearTerminalToolStripMenuItem.Click += clearTerminalToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            btnShowHidePrompting.Click += btnShowHidePrompting_Click;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += SaveDiagram;
            openToolStripMenuItem.Click += OpenDiagram;
            chartsToolStripMenuItem.Click += OpenChartsForm;
        }

        private void OpenChartsForm(object sender, EventArgs e){
            new ChartsForm(_terminalController).Show();
        }

        private void OpenDiagram(object sender, EventArgs e){
            if (ShowOpenFileDialog() == DialogResult.Cancel)
                return;
            MainController.Instance.OpenDiagramm(openFileDialog.FileName);
            _activityControlsController.CreateDiagramControls();
        }

        private DialogResult ShowOpenFileDialog(){
            openFileDialog.Title = Lang.Res.Open_diagramm;
            return openFileDialog.ShowDialog();
        }

        private void SaveDiagram(object sender, EventArgs e){
            if (OpenSaveFileDialog() == DialogResult.Cancel)
                return;
            if (DoNotWantToOverrideExistFile())
                return;
            MainController.Instance.SaveDiagramm(saveFileDialog.FileName);
        }

        private bool DoNotWantToOverrideExistFile(){
            return new FileInfo(saveFileDialog.FileName).Exists
                   && !Messenger.ShowConfirmation(Lang.Res.File_already_exist_overwrite);
        }

        private DialogResult OpenSaveFileDialog(){
            saveFileDialog.OverwritePrompt = false;
            saveFileDialog.FileName = MainController.Instance.ActivitiesController.DiagramFileName;
            saveFileDialog.Title = Lang.Res.Save_diagramm;
            return saveFileDialog.ShowDialog();
        }

        void _activityControlsController_OnExpandCompositeActivity(BaseActivity activity){
            var tabPage = new TabPage(activity.Name);
            tabControl.TabPages.Add(tabPage);
            tabPage.Focus();
        }

        static void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutForm().ShowDialog();
        }

        void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            _activityControlsController.DeleteSelected();
        }

        void btnShowHidePrompting_Click(object sender, EventArgs e){
            bool visible = !txtPrompting.Visible;
            txtPrompting.Visible = visible;
            splitContainer5.SplitterDistance = splitContainer5.Height - btnShowHidePrompting.Height - (visible ? 80 : 10);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e){
            Close();
        }

        private void clearTerminalToolStripMenuItem_Click(object sender, EventArgs e){
            txtTerminal.Clear();
        }

        private void btnShowHideTerminalControls_Click(object sender, EventArgs e){
            pnlTerminalControls.Visible = !pnlTerminalControls.Visible;
        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e){
            clearTerminalToolStripMenuItem.Enabled = TerminalPanel.Visible = terminalToolStripMenuItem.Checked;
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e){
            _activityControlsController.DeleteAll();
        }

        private void ClearActivityFactorySelection(){
            lvBasicActivities.SelectedItems.Clear();
            lvServices.SelectedItems.Clear();
        }

        private void lvBasicActivities_SelectedIndexChanged(object sender, EventArgs e){
            SelectActivityBy(sender);
        }

        private static void InitActivitiesFor(ListView listView, IEnumerable<ActivityFactoryBase> activities){
            var columnHeader = new ColumnHeader{Width = 100};
            listView.Columns.Add(columnHeader);
            foreach (ActivityFactoryBase elementFactory in activities) {
                var item = new ListViewItem(new[]{elementFactory.Name}){Tag = elementFactory};
                listView.Items.Add(item);
            }
        }

        private void SelectActivityBy(object sender){
            ListView.SelectedListViewItemCollection selectedItems = ((ListView) sender).SelectedItems;
            if (selectedItems.Count == 0)
                return;
            _activityControlsController.SelectedActivityFactory = (ActivityFactoryBase) selectedItems[0].Tag;
        }
    }
}