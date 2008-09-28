using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite{
    public partial class MainForm : Form{
        private readonly MainController _mainController;
        private readonly TerminalController _terminalController;

        public MainForm(){
            InitializeComponent();
            Lang.SwitchToRu();
            _terminalController = new TerminalController(this, btnConnect, btnSendATCommand, txtATCommand, txtTerminal);
            _mainController = new MainController(GetServices(), designFieldControl, txtPrompting);
            InitBasicActivities();
            terminalToolStripMenuItem.Checked = TerminalPanel.Visible;
            Bind();
            InterfaceLocalization();
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
        }

        private ServiceProvider GetServices(){
            var serviceProvider = new ServiceProvider();
            serviceProvider.BumperPorts = new List<IService>{
                                                                bumperControl1,
                                                                bumperControl2,
                                                                new ZegBeeBumperService("ZB " + Lang.Res.Bumper, 1, _terminalController.Communicator),
                                                                new ZegBeeBumperService("ZB " + Lang.Res.Bumper, 2, _terminalController.Communicator)
                                                            };
            serviceProvider.LEDPorts = new List<IService>{
                                                             ledControl1,
                                                             ledControl2,
                                                             new ZegBeeLEDService("ZB " + Lang.Res.LED,
                                                                                  _terminalController.Communicator)
                                                         };
            serviceProvider.DrivePorts = new List<IService>{
                                                               driveControl1, 
                                                               driveControl2,
                                                               new ZegBeeDriveService("ZB " + Lang.Res.Drive, 1, _terminalController.Communicator),
                                                               new ZegBeeDriveService("ZB " + Lang.Res.Drive, 2, _terminalController.Communicator)
                                                           };
            serviceProvider.MessengerPorts = new List<IService>{messengerEmulatorControl1};
            return serviceProvider;
        }

        private void InitBasicActivities(){
            InitActivitiesFor(lvBasicActivities, _mainController.BasicActivities);
            InitActivitiesFor(lvServices, _mainController.Services);
        }

        private void Bind(){
            _mainController.OnActivityControlPlaced += ClearActivityCreatorSelection;
            lvBasicActivities.SelectedIndexChanged += lvBasicActivities_SelectedIndexChanged;
            lvServices.SelectedIndexChanged += lvBasicActivities_SelectedIndexChanged;
            clearAllToolStripMenuItem.Click += clearAllToolStripMenuItem_Click;
            terminalToolStripMenuItem.Click += terminalToolStripMenuItem_Click;
            btnShowHideTerminalControls.Click += btnShowHideTerminalControls_Click;
            clearTerminalToolStripMenuItem.Click += clearTerminalToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            btnShowHidePrompting.Click += btnShowHidePrompting_Click;
        }

        void btnShowHidePrompting_Click(object sender, EventArgs e){
            bool visible = !txtPrompting.Visible;
            txtPrompting.Visible = visible;
            splitContainer5.SplitterDistance = splitContainer5.Height - btnShowHidePrompting.Height - (visible ? 80 : 10);
        }

        private SplitterPanel PromptingPanel{
            get { return splitContainer5.Panel2; }
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
            _mainController.ClearAll();
        }

        private void ClearActivityCreatorSelection(){
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
            _mainController.SelectedActivityCreator = (ActivityCreatorBase) selectedItems[0].Tag;
        }
    }
}