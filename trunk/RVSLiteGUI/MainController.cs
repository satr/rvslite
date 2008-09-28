using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RVSLite.Controls;
using RVSLite.Controls.ActivityControls;

namespace RVSLite {
    public delegate void ActionEventHandler();

    public class MainController {
        public const int CellSpan = 5;
        public const int CellWH = 80;
        private readonly ActivitiesController _activitiesController;
        private readonly DesignFieldControl _designFieldControl;
        private static RichTextBox _txtPrompting;
        private readonly ServiceProvider _serviceProvider;
        private const int _columnCount = 20;
        private const int _rowCount = 20;


        public MainController(ServiceProvider serviceProvider, DesignFieldControl designFieldControl, RichTextBox txtPrompting) {
            _serviceProvider = serviceProvider;
            _designFieldControl = designFieldControl;
            _txtPrompting = txtPrompting;
            _activitiesController = new ActivitiesController(_serviceProvider);
            InitActivitiesList();
            ActivityControls = new IActivityControl[_columnCount, _rowCount];
            Bind();
        }

        public static void WritePrompting(string[] lines){
            WritePrompting(string.Join("\r\n", lines));
        }
        public static void WritePrompting(StringBuilder builder) {
            WritePrompting(builder.ToString());
        }
        public static void WritePrompting(string text) {
            if (_txtPrompting == null)
                return;
            _txtPrompting.Text = text;
        }

        private bool ActivityCreatorIsNotSelected {
            get { return SelectedActivityCreator == null; }
        }

        public List<ActivityCreatorBase> BasicActivities { get; private set; }
        public IEnumerable<ActivityCreatorBase> Services { get; private set; }

        public ActivitiesController ActivitiesController {
            get { return _activitiesController; }
        }

        public IActivityControl[,] ActivityControls { get; private set; }

        public ActivityCreatorBase SelectedActivityCreator { get; set; }
        public event ActionEventHandler OnActivityControlPlaced;

        private void Bind() {
            _designFieldControl.OnClickInPos += designFieldControl_OnClickInPos;
        }

        private void designFieldControl_OnClickInPos(int column, int row) {
            if (ActivityCreatorIsNotSelected)
                return;
            IActivityControl activityControl = SelectedActivityCreator.GetControl();
            var sourceActivityControl = GetSourceNeighbourActivityControlBy(column, row);
            var sourceActivity = sourceActivityControl == null ? new NullActivity() : sourceActivityControl.Activity;
            ActivitiesController.RegisterActivity(sourceActivity, activityControl.Activity);
            RegisterActivityControl(activityControl, sourceActivity, column, row);
            _designFieldControl.PlaceActivityControlAt(activityControl, column, row);
            activityControl.Init();
            ClearActivityCreatorSelection();
        }

        private IActivityControl GetNeighbourActivityBy(int column, int row, NeighbourDirections direction) {
            if (direction == NeighbourDirections.Left)
                return column == 0 ? null : ActivityControls[column - 1, row];
            if (direction == NeighbourDirections.Right)
                return column == _columnCount ? null : ActivityControls[column + 1, row];
            if (direction == NeighbourDirections.Top)
                return row == 0 ? null : ActivityControls[column, row - 1];
            return row == _rowCount ? null : ActivityControls[column, row + 1];
        }


        public IActivityControl GetSourceNeighbourActivityControlBy(int column, int row) {
            foreach (NeighbourDirections direction in GetNeighbourDirections()) {
                var activityControl = GetNeighbourActivityBy(column, row, direction);
                if (activityControl != null)
                    return activityControl;
            }
            return null;
        }

        private static NeighbourDirections[] GetNeighbourDirections() {
            return new[]{
                            NeighbourDirections.Left, NeighbourDirections.Top, NeighbourDirections.Bottom,
                            NeighbourDirections.Right
                        };
        }

        private void ClearActivityCreatorSelection() {
            SelectedActivityCreator = null;
            if (OnActivityControlPlaced != null)
                OnActivityControlPlaced();
        }


        private void InitActivitiesList() {
            BasicActivities = new List<ActivityCreatorBase>{
                                                               new StartActivityCreator(
                                                                   _activitiesController.ServiceProvider),
                                                               new DataActivityCreator(
                                                                   _activitiesController.ServiceProvider),
                                                               new VariableActivityCreator(
                                                                   _activitiesController.ServiceProvider),
                                                               new ConnectionActivityCreator(
                                                                   _activitiesController.ServiceProvider),
                                                               new JoinActivityCreator(
                                                                   _activitiesController.ServiceProvider),
                                                               new IfClauseActivityCreator(
                                                                   _activitiesController.ServiceProvider),
                                                               new CalculateActivityCreator(
                                                                   _activitiesController.ServiceProvider),
                                                               new PauseActivityCreator(
                                                                   _activitiesController.ServiceProvider),
                                                           };
            Services = new List<ActivityCreatorBase>{
                                                        new BumperServiceCreator(_activitiesController.ServiceProvider),
                                                        new DriveServiceCreator(_activitiesController.ServiceProvider),
                                                        new LEDServiceCreator(_activitiesController.ServiceProvider),
                                                        new MessengerServiceCreator(_activitiesController.ServiceProvider)
                                                    };
        }

        public void RegisterActivityControl(IActivityControl activityControl, BaseActivity sourceActivity, int column, int row) {
            ActivityControls[column, row] = activityControl;
            activityControl.SourceActivity = sourceActivity;
        }

        public void ClearAll() {
            for (int column = 0; column < _columnCount; column++) {
                for (int row = 0; row < _rowCount; row++) {
                    var activityControl = ActivityControls[column, row];
                    if (activityControl == null)
                        continue;
                    ActivityControls[column, row] = null;
                    _designFieldControl.Controls.Remove((Control)activityControl);
                    ActivitiesController.UnregisterActivity(activityControl.Activity);
                }
            }
        }

        public static void InitControlBy(IActivityControl activityControl, Control groupBox, params Control[] controls){
            var control = (Control)activityControl;
            activityControl.DefaultBGColor = control.BackColor;
            groupBox.Size = new Size(control.Width - CellSpan*2, control.Height - CellSpan*2);
            groupBox.Location = new Point(CellSpan, CellSpan);
            control.Click += ChangeSelection;
            groupBox.Click += ChangeSelectionForParent;
            foreach (var subControl in controls)
                subControl.Click += ChangeSelectionForParentofParent;
        }

        private static void ChangeSelectionForParentofParent(object sender, EventArgs e){
            ChangeSelectionFor((IActivityControl) ((Control)sender).Parent.Parent);
        }

        private static void ChangeSelectionForParent(object sender, EventArgs e){
            ChangeSelectionFor((IActivityControl) ((Control)sender).Parent);
        }

        static void ChangeSelection(object sender, EventArgs e){
            ChangeSelectionFor((IActivityControl)sender);
        }

        private static void ChangeSelectionFor(IActivityControl activityControl){
            activityControl.Selected = !activityControl.Selected;
            ((Control)activityControl).BackColor = activityControl.Selected ? Color.DarkGray : activityControl.DefaultBGColor;
            activityControl.FireOnClickActivityControl();
        }
    }
}