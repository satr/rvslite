using System.Collections;
using System.Collections.Generic;
using RVSLite.Controls;

namespace RVSLite{
    public abstract class ElementCreatorBase{
        protected List<BaseOperator> _instances = new List<BaseOperator>();
        protected readonly IServiceProvider _serviceProvider;

        protected ElementCreatorBase(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
        }

        public abstract string Name { get; }

        public virtual List<BaseOperator> Instances{
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

        public bool ExistAnotherInstanceWith(string name, BaseOperator sourceOperator){
            foreach (BaseOperator instance in Instances){
                if (instance != sourceOperator && instance.Name == name)
                    return true;
            }
            return false;
        }

        public abstract BaseOperator Create();
    }
}