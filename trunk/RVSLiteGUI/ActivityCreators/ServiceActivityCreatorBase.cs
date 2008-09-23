using System.Collections;
using System.Collections.Generic;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public abstract class ServiceActivityCreatorBase : ActivityCreatorBase{
        protected object _selectedPort;

        protected ServiceActivityCreatorBase(IServiceProvider services) : base(services){
        }

        protected abstract List<IService> GetServices();

        protected abstract void Subscribe(IService service, BaseActivity activity);

        public override bool IsPredefinedList{
            get { return true; }
        }

        public override BaseActivity Create(){
            return new ServiceActivity(Name);
        }

        protected override IActivityControl CreateActivityControl(){
            return new ServiceActivityControl{
                                         ControlName = Name,
                                         Ports = GetServices(),
                                         Activity = Create()
                                     };
        }
    }
}