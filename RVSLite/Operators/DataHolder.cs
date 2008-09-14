﻿namespace RVSLite{
    public class DataHolder : ValueHolder{
        public DataHolder(object value) : base(Lang.Res.Constant, value){
        }

        public override string ToString() {
            return string.Format("{0}", Value == null ? Lang.Res.Empty : Value.ToString());
        }
    }
}