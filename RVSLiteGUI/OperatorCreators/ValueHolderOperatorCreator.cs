using System.Collections;
using System.Collections.Generic;

namespace RVSLite{
    public class ValueHolderOperatorCreator : OperatorCreatorBase {
        private BaseOperator _newInstance;
        public ValueHolderOperatorCreator(IServiceProvider serviceProvider) : base(serviceProvider) {}

        public override BaseOperator Create(){
            return new ValueHolder(Name);
        }

        public override string Name {
            get { return Lang.Res.Value; }
        }

        public override bool IsCollectable {
            get { return true; }
        }

        public override List<BaseOperator> Instances {
            get { return ServiceProvider.ValueHolders; }
        }
    }
}