namespace RVSLite{
    public class NullValueHolder : ValueHolder{
        #region IValueHolder Members

        public override object Value{
            get { return null; }
            set { }
        }

        public override string Name{
            get { return Lang.Res.Empty; }
        }

        #endregion
    }
}