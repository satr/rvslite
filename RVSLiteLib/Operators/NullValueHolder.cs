namespace RVSLite{
    public class NullValueHolder : ValueHolder{
        new public static readonly string OperatorName = Lang.Res.Empty;
        #region IValueHolder Members

        public override object Value{
            get { return null; }
            set { }
        }

        public override string Name{
            get { return OperatorName; }
        }

        #endregion
    }
}