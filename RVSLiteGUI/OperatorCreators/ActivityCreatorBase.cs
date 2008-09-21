using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using RVSLite.Controls;

namespace RVSLite{
    public abstract class ActivityCreatorBase{
        protected List<BaseActivity> _instances = new List<BaseActivity>();
        protected readonly IServiceProvider _serviceProvider;

        protected ActivityCreatorBase(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
        }

        public abstract string Name { get; }

        public virtual List<BaseActivity> Instances{
            get { return _instances; }
        }

        public virtual bool RequireInitValue {
            get{ return false;}
        }

        public virtual bool RequireSourceElement {
            get{ return true;}
        }

        public virtual bool IsCollectable {
            get { return false; }
        }

        public IServiceProvider ServiceProvider {
            get { return _serviceProvider; }
        }

        public virtual bool IsOperatorWithOperation {
            get { return false; }
        }

        public virtual bool IsAnonymous{
            get { return false; }
        }

        public virtual bool IsPredefinedList{
            get { return false; }
        }

        public bool ExistAnotherInstanceWith(string name, BaseActivity sourceActivity){
            foreach (BaseActivity instance in Instances){
                if (instance != sourceActivity && instance.Name == name)
                    return true;
            }
            return false;
        }

        public abstract BaseActivity Create();

        public Control GetControl(BaseActivity activity){
            var control = new DoControl();
            control.Activity = activity;
            return control;
        }
    }
}