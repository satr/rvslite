using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using RVSLite.Controls;

namespace RVSLite {
    public class MainController {
        const string LINK_NODE = "Link";
        const string SOURCE_ATTRIBUTE = "Source";
        const string ACTIVITY_NODE = "Activity";
        const string FACTORY_KEY_ATTRIBUTE = "FactoryKey";
        private readonly ActivitiesController _activitiesController;
        private static RichTextBox _txtPrompting;
        private readonly TabControl _tabControl;
        private static MainController _instance;
        readonly Dictionary<string, ActivityFactoryBase> _factoriesDictionary = new Dictionary<string, ActivityFactoryBase>();

        private readonly IDictionary<CompositeActivity, TabPage> _compositeActivityTabs =
            new Dictionary<CompositeActivity, TabPage>();

        private MainController(ActivitiesController activitiesController, RichTextBox txtPrompting,
                               TabControl tabControl) {
            _activitiesController = activitiesController;
            _txtPrompting = txtPrompting;
            _tabControl = tabControl;
            InitActivitiesList(_activitiesController.ServiceProvider);
        }

        public static MainController Instance {
            get { return _instance; }
        }

        public List<ActivityFactoryBase> BasicActivities { get; private set; }
        public List<ActivityFactoryBase> Services { get; private set; }


        public static void WritePrompting(string[] lines) {
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


        private void InitActivitiesList(IServiceProvider serviceProvider){
            BasicActivities = new List<ActivityFactoryBase>{
                                                               AddFactory(new StartActivityFactory(serviceProvider)),
                                                               AddFactory(new DataActivityFactory(serviceProvider)),
                                                               AddFactory(new VariableActivityFactory(serviceProvider)),
                                                               AddFactory(new ConnectActivityFactory(serviceProvider)),
                                                               AddFactory(new JoinActivityFactory(serviceProvider)),
                                                               AddFactory(new IfClauseActivityFactory(serviceProvider)),
                                                               AddFactory(new CalculateActivityFactory(serviceProvider)),
                                                               AddFactory(new PauseActivityFactory(serviceProvider))
                                                           };
            Services = new List<ActivityFactoryBase>{
                                                        AddFactory(new BumperServiceFactory(serviceProvider)),
                                                        AddFactory(new DriveServiceFactory(serviceProvider)),
                                                        AddFactory(new LEDServiceFactory(serviceProvider)),
                                                        AddFactory(new DisplayServiceFactory(serviceProvider))
                                                    };
        }

        private ActivityFactoryBase AddFactory(ActivityFactoryBase serviceFactory){
            _factoriesDictionary.Add(serviceFactory.FactoryKey, serviceFactory);
            return serviceFactory;
        }

        public static void InitBy(ActivitiesController activitiesController, RichTextBox prompting,
                                  TabControl tabControl) {
            _instance = new MainController(activitiesController, prompting, tabControl);
        }

        public void OpenCompositeActivityFor(CompositeActivity activity) {
            if (!_compositeActivityTabs.ContainsKey(activity)) {
                _compositeActivityTabs.Add(activity, new TabPage(activity.Name));
                _tabControl.TabPages.Add(_compositeActivityTabs[activity]);
            }
            _tabControl.SelectedTab = _compositeActivityTabs[activity];
            var designFieldControl = new DesignFieldControl();
            _compositeActivityTabs[activity].Controls.Add(designFieldControl);
            designFieldControl.Dock = DockStyle.Fill;
        }

        public ActivitiesController ActivitiesController {
            get { return _activitiesController; }
        }

        public void SaveDiagramm(string fileName) {
            using (var reader = new XmlTextWriter(fileName, Encoding.Unicode)) {
                reader.WriteStartDocument();
                reader.WriteStartElement("Diagram");
                foreach (ActivitiesLink activitiesLink in _activitiesController.ActivitiesLinks) {
                    reader.WriteStartElement(LINK_NODE);
                    reader.WriteStartElement(SOURCE_ATTRIBUTE);
                    reader.WriteAttributeString(ActivityFactoryBase.ID_ATTRIBUTE, activitiesLink.SourceActivity.ID);
                    reader.WriteEndElement();
                    reader.WriteStartElement(ACTIVITY_NODE);
                    reader.WriteAttributeString(ActivityFactoryBase.ID_ATTRIBUTE, activitiesLink.TargetActivity.ID);
                    reader.WriteAttributeString(ActivityFactoryBase.NAME_ATTRIBUTE, activitiesLink.TargetActivity.Name);
                    reader.WriteAttributeString(FACTORY_KEY_ATTRIBUTE, activitiesLink.TargetActivity.FactoryKey);
                    reader.WriteEndElement();
                    reader.WriteEndElement();
                }
                reader.WriteEndElement();
                reader.WriteEndDocument();
            }
        }

        public void OpenDiagramm(string fileName){
            var activitiesDict = LoadLinksAndActivities(fileName);
            AssignSources(_activitiesController, activitiesDict);
            _activitiesController.PlaceLinksToGrid();
        }

        private Dictionary<string, BaseActivity> LoadLinksAndActivities(string fileName){
            var activities = new Dictionary<string, BaseActivity>();
            var activitiesLink = new ActivitiesLink();
            using (var reader = new XmlTextReader(fileName)) {
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read()){
                    if (reader.NodeType == XmlNodeType.Element){
                        if (reader.Name == LINK_NODE){
                            activitiesLink = new ActivitiesLink();
                            _activitiesController.ActivitiesLinks.Add(activitiesLink);
                        }
                        else if (reader.Name == SOURCE_ATTRIBUTE){
                            var activityId = reader.GetAttribute(ActivityFactoryBase.ID_ATTRIBUTE);
                            activitiesLink.SourceActivity = new NullActivity(){ID = activityId};
                        }
                        else if (reader.Name == ACTIVITY_NODE){
                            var targetActivity = CreateActivityByKey(reader);
                            activities.Add(targetActivity.ID, targetActivity);
                            activitiesLink.TargetActivity = targetActivity;
                        }
                    }
                }
            }
            return activities;
        }

        private static void AssignSources(ActivitiesController activitiesController, IDictionary<string, BaseActivity> activities){
            foreach (var activitiesLink in activitiesController.ActivitiesLinks){
                if (activitiesLink.SourceActivity.IdIsEmpty)
                    activitiesController.AddStartPoint(activitiesLink);
                else
                    activitiesLink.SourceActivity = activities[activitiesLink.SourceActivity.ID];
            }
        }

        private BaseActivity CreateActivityByKey(XmlTextReader reader){
            return _factoriesDictionary[reader.GetAttribute(FACTORY_KEY_ATTRIBUTE)].CreateActivityBy(reader);
        }

        public ActivityFactoryBase GetActivityFactoryBy(string factoryKey){
            return _factoriesDictionary[factoryKey]; 
        }
    }
}