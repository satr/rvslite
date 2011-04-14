using System;
using System.Collections.Generic;
using System.Text;

namespace RVSLite {
    public class CompositeActivity: BaseActivity {
        public override void Post(object value){
            FireOnPost(value);
        }
    }
}
