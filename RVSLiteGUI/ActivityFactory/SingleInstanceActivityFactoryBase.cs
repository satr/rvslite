using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace RVSLite{
    public abstract class SingleInstanceActivityFactoryBase : BaseActivityFactoryBase{
        protected SingleInstanceActivityFactoryBase(IServiceProvider serviceProvider) : base(serviceProvider) {
        }

        public override List<BaseActivity> Instances{
            get{
                _instances.Clear();
                _instances.Add(Create());
                return _instances;
            }
        }


        protected abstract BaseActivity Create();

        public override BaseActivity CreateActivityBy(XmlTextReader xmlTextReader) {
            return Create().SetId(GetIdFrom(xmlTextReader));
        }
    }
}