using System.Collections;
using System.Collections.Generic;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public abstract class ServiceActivityCreatorBase : ActivityCreatorBase{
        private readonly bool _canFirePost;
        protected object _selectedPort;

        protected ServiceActivityCreatorBase(IServiceProvider services, bool canFirePost) : base(services){
            _canFirePost = canFirePost;
        }

        protected abstract List<IService> GetServices();

        protected abstract void Subscribe(IService service, BaseActivity activity);

        public override bool IsPredefinedList{
            get { return true; }
        }

        public override BaseActivity Create(){
            return new ServiceActivity(Name, _canFirePost);
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