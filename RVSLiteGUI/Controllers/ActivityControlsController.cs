using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RVSLite.Controls;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class ActivityControlsController{
        public event ActionEventHandler OnActivityControlPlaced;
        public event LinkedActivitiesEventHandler OnRegisterActivity;
        public event ActivityEventHandler OnUnregisterActivity;
        public event ActivityEventHandler OnExpandCompositeActivity;
        private const int CellSpan = 5;
        private readonly DesignFieldControl _designFieldControl;
        private const int _columnCount = 100;
        private const int _rowCount = 200;
        private readonly List<IActivityControl> _selectedActivityControls = new List<IActivityControl>();
        private IActivityControl _firstSelectedActivityControl;

        public ActivityControlsController(DesignFieldControl designFieldControl){
            _designFieldControl = designFieldControl;
            ActivityControls = new IActivityControl[_columnCount,_rowCount];
            _designFieldControl.OnClickInPos += designFieldControl_OnClickInPos;
        }

        public IActivityControl[,] ActivityControls { get; private set; }

        private static void ChangeSelectionColorFor(IActivityControl activityControl){
            ((Control) activityControl).BackColor = activityControl.Selected
                                                        ? Color.DarkGray
                                                        : activityControl.DefaultBGColor;
        }

        void activityControl_OnClickActivityControl(IActivityControl activityControl) {
            InvertSelectionFor(activityControl);
            SelectFirstSelectedIfNoSelection(activityControl);
            if (ShiftKeyIsPressed && SelectedSomeActivityControls) {
                SelectActivityControlsInRange(_firstSelectedActivityControl, activityControl);
                return;
            }
            ClearAllSelection();
            ReplaceFirstSelectedWith(activityControl);
            AddRemoveToSelectedList(activityControl);
        }

        private bool SelectedSomeActivityControls{
            get { return _selectedActivityControls.Count > 0; }
        }

        private static bool ShiftKeyIsPressed{
            get { return (Control.ModifierKeys & Keys.Shift) != Keys.None; }
        }

        private static bool CtrlKeyIsPressed{
            get { return (Control.ModifierKeys & Keys.Control) != Keys.None; }
        }

        private void ReplaceFirstSelectedWith(IActivityControl activityControl){
            _firstSelectedActivityControl = activityControl;
        }

        private void SelectActivityControlsInRange(IActivityControl firstSelectedActivityControl,
                                        IActivityControl currentActivityControl){
            Position startPosition = GetPosOf(firstSelectedActivityControl);
            Position finishPosition = GetPosOf(currentActivityControl);
            //изменить чтобы упорядочить по углам
            ClearAllSelection();
            for (int column = startPosition.Column; column <= finishPosition.Column; column++){
                for (int row = startPosition.Row; row <= finishPosition.Row; row++){
                    IActivityControl activityControl = ActivityControls[column, row];
                    if (activityControl == null)
                        continue;
                    activityControl.Selected = true;
                    AddToSelectedList(activityControl);
                }
            }
        }

        private void ClearAllSelection(){
            foreach (IActivityControl activityControl in new List<IActivityControl>(_selectedActivityControls)){
                activityControl.Selected = false;
                RemoveFromSelectedList(activityControl);
            }
        }

        private Position GetPosOf(IActivityControl activityControl){
            for (int column = 0; column < _columnCount; column++){
                for (int row = 0; row < _rowCount; row++){
                    if (ActivityControls[column, row] != activityControl)
                        continue;
                    return new Position(column, row);
                }
            }
            throw new Exception("Position is undefined for control");
        }

        private void SelectFirstSelectedIfNoSelection(IActivityControl activityControl){
            if (_firstSelectedActivityControl == null)
                _firstSelectedActivityControl = activityControl;
        }

        private void AddRemoveToSelectedList(IActivityControl activityControl){
            if (AddToSelectedList(activityControl))
                return;
            RemoveFromSelectedList(activityControl);
        }

        private void RemoveFromSelectedList(IActivityControl activityControl){
            if (_selectedActivityControls.Contains(activityControl))
                _selectedActivityControls.Remove(activityControl);
            ChangeSelectionColorFor(activityControl);
        }

        private bool AddToSelectedList(IActivityControl activityControl){
            if (!activityControl.Selected)
                return false;
            if (!_selectedActivityControls.Contains(activityControl))
                _selectedActivityControls.Add(activityControl);
            ChangeSelectionColorFor(activityControl);
            return true;
        }

        private IActivityControl GetNeighbourActivityControlBy(int column, int row, NeighbourDirections direction){
            if (direction == NeighbourDirections.Left)
                return column == 0 ? null : ActivityControls[column - 1, row];
            if (direction == NeighbourDirections.Right)
                return column == _columnCount ? null : ActivityControls[column + 1, row];
            if (direction == NeighbourDirections.Top)
                return row == 0 ? null : ActivityControls[column, row - 1];
            return row == _rowCount ? null : ActivityControls[column, row + 1];
        }


        public ActivityControlsLink GetSourceNeighbourActivityControlBy(int column, int row) {
            foreach (var direction in GetNeighbourDirections()){
                var activityControl = GetNeighbourActivityControlBy(column, row, direction);
                if (activityControl is IActivityControl2 
                    && !((IActivityControl2) activityControl).OutputAvailableTo(direction))
                    continue;
                if (activityControl != null)
                    return new ActivityControlsLink(activityControl, direction);
            }
            return null;
        }

        private static NeighbourDirections[] GetNeighbourDirections(){
            return new[]{
                            NeighbourDirections.Left, NeighbourDirections.Top, NeighbourDirections.Bottom,
                            NeighbourDirections.Right
                        };
        }
         public void RegisterActivityControl(IActivityControl activityControl, BaseActivity sourceActivity, ActivityControlsLink sourceActivityControlsLink, int column, int row) {
            ActivityControls[column, row] = activityControl;
            activityControl.SourceActivity = sourceActivity;
            activityControl.OnClickActivityControl += activityControl_OnClickActivityControl;
            _designFieldControl.PlaceActivityControlAt(column, row, activityControl, sourceActivityControlsLink);
            activityControl.Init();
        }

         void ActivityControlsController_OnDoubleClickActivityControl(IActivityControl activityControl) {
             if (OnExpandCompositeActivity != null)
                 OnExpandCompositeActivity(activityControl.Activity);
         }

        private static void InvertSelectionFor(IActivityControl activityControl){
            activityControl.Selected = !activityControl.Selected;
        }


        public void DeleteAll(){
            DeleteActivityControlsList(GetAllRemovedActivityControls());
        }

        public void DeleteSelected() {
            DeleteActivityControlsList(_selectedActivityControls);
        }

        private void DeleteActivityControlsList(IEnumerable<IActivityControl> activityControls) {
            foreach (var activityControl in new List<IActivityControl>(activityControls)){
                _designFieldControl.Controls.Remove((Control)activityControl);
                if (OnUnregisterActivity != null)
                    OnUnregisterActivity(activityControl.Activity);
                RemoveFromSelectedList(activityControl);
                activityControl.OnClickActivityControl -= activityControl_OnClickActivityControl;
            }
        }

        private IEnumerable<IActivityControl> GetAllRemovedActivityControls(){
            for (int column = 0; column < _columnCount; column++) {
                for (int row = 0; row < _rowCount; row++) {
                    var activityControl = ActivityControls[column, row];
                    ActivityControls[column, row] = null;
                    if (activityControl != null)
                        yield return activityControl;
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
            activityControl.FireOnClickActivityControl();
        }

        private void designFieldControl_OnClickInPos(int column, int row) {
            if (ActivityFactoryIsNotSelected)
                return;
            var activityControl = SelectedActivityFactory.CreateActivityControl();
            activityControl.Selected = true;//preinvert - to fix a_bug
            var sourceActivityControlsLink = GetSourceNeighbourActivityControlBy(column, row);
            var sourceActivity = sourceActivityControlsLink == null
                                              ? new NullActivity()
                                              : sourceActivityControlsLink.SourceActivityControl.Activity;
            if(OnRegisterActivity != null)
                OnRegisterActivity(sourceActivity, activityControl.Activity);
            RegisterActivityControl(activityControl, sourceActivity, sourceActivityControlsLink, column, row);
            ClearActivityFactorySelection();
        }

        public void CreateDiagramControls() {
            foreach (var activitiesLink in MainController.Instance.ActivitiesController.ActivitiesLinks) {
                var activityFactory = MainController.Instance.GetActivityFactoryBy(activitiesLink.TargetActivity.FactoryKey);
                var activityControl = activityFactory.GetControl(activitiesLink.TargetActivity);
                activityControl.SourceActivity = activitiesLink.SourceActivity;
            }
        }
        
        private bool ActivityFactoryIsNotSelected {
            get { return SelectedActivityFactory == null; }
        }

        public ActivityFactoryBase SelectedActivityFactory { get; set; }
        
        private void ClearActivityFactorySelection() {
            SelectedActivityFactory = null;
            if (OnActivityControlPlaced != null)
                OnActivityControlPlaced();
        }

    }
}