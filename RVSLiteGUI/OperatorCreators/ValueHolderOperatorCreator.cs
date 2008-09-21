using System.Collections.Generic;

namespace RVSLite{
    public class ValueHolderOperatorCreator : OperatorCreatorBase{
        public ValueHolderOperatorCreator(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Variable; }
        }

        public override bool IsCollectable{
            get { return true; }
        }

        public override List<BaseOperator> Instances{
            get { return ServiceProvider.ValueHolders; }
        }

        public override BaseOperator Create(){
            return new ValueHolder(Name);
        }
    }
}