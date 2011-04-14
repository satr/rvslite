using System.Collections.Generic;
using System.Xml;

namespace RVSLite{
    public abstract class ActivityFactoryBase{
        public const string ID_ATTRIBUTE = "ID";
        public const string NAME_ATTRIBUTE = "Name";
        protected readonly IServiceProvider _serviceProvider;
        protected List<BaseActivity> _instances = new List<BaseActivity>();

        protected ActivityFactoryBase(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
        }

        public abstract string Name { get; }

        public virtual List<BaseActivity> Instances{
            get { return _instances; }
        }

        public IServiceProvider ServiceProvider{
            get { return _serviceProvider; }
        }

        public abstract IActivityControl CreateActivityControl();

        public abstract string FactoryKey { get; }

        public abstract BaseActivity CreateActivityBy(XmlTextReader xmlTextReader);

        protected static string GetNameFrom(XmlTextReader xmlTextReader){
            return xmlTextReader.GetAttribute(NAME_ATTRIBUTE);
        }

        protected static string GetIdFrom(XmlTextReader xmlTextReader){
            return xmlTextReader.GetAttribute(ID_ATTRIBUTE);
        }

        public IActivityControl GetControl(BaseActivity activity){
            var activityControl = CreateActivityControl();
            activityControl.Activity = activity;
            return activityControl;
        }
    }
}