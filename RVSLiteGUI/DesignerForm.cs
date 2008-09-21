using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RVSLite {
    public partial class DesignerForm : Form {
        private readonly MainController _mainController;
        private ActivityCreatorBase _selectedBasicActivity;

        public DesignerForm(MainController mainController){
            _mainController = mainController;
            InitializeComponent();
            InitBasicActivities();

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
            KeyUp += new KeyEventHandler(DesignerForm_KeyUp);
        }

        void designFieldControl_OnClickInPos(RVSLite.Controls.DesignFieldControl designFieldControl, int column, int row) {
            if (_selectedBasicActivity == null)
                return;
            BaseActivity activity = _selectedBasicActivity.Create();
            _mainController.RegisterActivityAt(activity, column, row);
            designFieldControl.PlaceActivityControlAt(_selectedBasicActivity.GetControl(activity), column, row);
            ClearSelection();
        }

        void DesignerForm_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Escape)
                return;
            ClearSelection();
        }


        void designFieldControl_Click(object sender, EventArgs e){
            ClearSelection();
        }

        private void ClearSelection(){
            _selectedBasicActivity = null;
            lvBasicActivities.SelectedItems.Clear();
            lvServices.SelectedItems.Clear();
        }

        void lvBasicActivities_SelectedIndexChanged(object sender, EventArgs e) {
            SelectActivityBy(sender);
        }

        private static void InitActivitiesFor(ListView listView, IEnumerable<ActivityCreatorBase> activities){
            var columnHeader = new ColumnHeader{Width = 100};
            listView.Columns.Add(columnHeader);
            foreach (var elementCreator in activities){
                var item = new ListViewItem(new[]{elementCreator.Name}){Tag = elementCreator};
                listView.Items.Add(item);
            }
        }

       private void SelectActivityBy(object sender){
            ListView.SelectedListViewItemCollection selectedItems = ((ListView)sender).SelectedItems;
            if (selectedItems.Count == 0)
                return;
            _selectedBasicActivity = (ActivityCreatorBase) selectedItems[0].Tag;
        }
    }
}
