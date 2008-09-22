using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RVSLite.Controls;

namespace RVSLite{
    public partial class DesignerForm : Form{
        private readonly MainController _mainController;
        private ActivityCreatorBase _selectedBasicActivity;

        public DesignerForm(){
            InitializeComponent();
            Lang.SwitchToRu();
            _mainController = new MainController(GetServices());
            InitBasicActivities();
        }

        private ServiceProvider GetServices(){
            var serviceProvider = new ServiceProvider();
            serviceProvider.BumperPorts = new List<IService>{bumperControl1, bumperControl2};
            serviceProvider.LEDPorts = new List<IService>{ledControl1, ledControl2};
            serviceProvider.DrivePorts = new List<IService>{driveControl1, driveControl2};
            return serviceProvider;
        }

        private void InitBasicActivities(){
            InitActivitiesFor(lvBasicActivities, _mainController.BasicActivities);
            InitActivitiesFor(lvServices, _mainController.Services);
            Bind();
        }

        private void Bind(){
            lvBasicActivities.SelectedIndexChanged += lvBasicActivities_SelectedIndexChanged;
            lvServices.SelectedIndexChanged += lvBasicActivities_SelectedIndexChanged;
            designFieldControl.OnClickInPos += designFieldControl_OnClickInPos;
            KeyUp += DesignerForm_KeyUp;
        }

        private void designFieldControl_OnClickInPos(DesignFieldControl designFieldControl, int column, int row){
            if (_selectedBasicActivity == null)
                return;
            var activity = _selectedBasicActivity.Instances[0];
            _mainController.RegisterActivityAt(activity, column, row);
            designFieldControl.PlaceActivityControlAt(_selectedBasicActivity.GetControl(activity), column, row);
            ClearSelection();
        }

        private void DesignerForm_KeyUp(object sender, KeyEventArgs e){
            if (e.KeyCode != Keys.Escape)
                return;
            ClearSelection();
        }


        private void designFieldControl_Click(object sender, EventArgs e){
            ClearSelection();
        }

        private void ClearSelection(){
            _selectedBasicActivity = null;
            lvBasicActivities.SelectedItems.Clear();
            lvServices.SelectedItems.Clear();
        }

        private void lvBasicActivities_SelectedIndexChanged(object sender, EventArgs e){
            SelectActivityBy(sender);
        }

        private static void InitActivitiesFor(ListView listView, IEnumerable<ActivityCreatorBase> activities){
            var columnHeader = new ColumnHeader{Width = 100};
            listView.Columns.Add(columnHeader);
            foreach (ActivityCreatorBase elementCreator in activities){
                var item = new ListViewItem(new[]{elementCreator.Name}){Tag = elementCreator};
                listView.Items.Add(item);
            }
        }

        private void SelectActivityBy(object sender){
            ListView.SelectedListViewItemCollection selectedItems = ((ListView) sender).SelectedItems;
            if (selectedItems.Count == 0)
                return;
            _selectedBasicActivity = (ActivityCreatorBase) selectedItems[0].Tag;
        }
    }
}