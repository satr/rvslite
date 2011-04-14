using System.Collections;
using System.Collections.Generic;
using System.Xml;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public abstract class ServiceActivityFactoryBase : ActivityFactoryBase{
        private readonly bool _canFirePost;
        protected object _selectedPort;

        protected ServiceActivityFactoryBase(IServiceProvider services, bool canFirePost) : base(services){
            _canFirePost = canFirePost;
        }

        protected abstract List<IService> GetServices();

        protected abstract void Subscribe(IService service, BaseActivity activity);

        public override IActivityControl CreateActivityControl(){
            return new ServiceActivityControl{
                                         ControlName = Name,
                                         Ports = GetServices(),
                                         Activity = Create(Name)
                                     };
        }

        private ServiceActivity Create(string name){
            return new ServiceActivity(name, _canFirePost) { FactoryKey = FactoryKey };
        }

        public override BaseActivity CreateActivityBy(XmlTextReader xmlTextReader){
            return Create(GetNameFrom(xmlTextReader)).SetId(GetIdFrom(xmlTextReader));
        }
    }
}