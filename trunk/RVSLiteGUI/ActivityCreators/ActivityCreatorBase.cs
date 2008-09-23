using System.Collections.Generic;
using System.Windows.Forms;
using RVSLite.Controls;

namespace RVSLite{
    public abstract class ActivityCreatorBase{
        protected readonly IServiceProvider _serviceProvider;
        protected List<BaseActivity> _instances = new List<BaseActivity>();

        protected ActivityCreatorBase(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
        }

        public abstract string Name { get; }

        public virtual List<BaseActivity> Instances{
            get { return _instances; }
        }

        public IServiceProvider ServiceProvider{
            get { return _serviceProvider; }
        }

        #region Obsolete

        public virtual bool RequireInitValue{
            get { return false; }
        }

        public virtual bool RequireSourceElement{
            get { return true; }
        }

        public virtual bool IsCollectable{
            get { return false; }
        }

        public virtual bool IsOperatorWithOperation{
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

        #endregion

        public abstract BaseActivity Create();

        public Control GetControl(){
            return (Control) CreateActivityControl();
        }

        protected virtual IActivityControl CreateActivityControl(){
            return new JoinActivityControl{Activity = Create()};
        }
    }
}