using System.Globalization;

namespace RVSLite{
    public class NegatorActivity : BaseActivity{
        public static readonly string OperatorName = Lang.Res.Negate_entry_value;

        public override string Name{
            get { return OperatorName; }
            set { }
        }

        public override void Post(object value){
            if (value == null){
                base.Post(value);
                return;
            }
            int intVal;
            if (value is bool)
                base.Post(!((bool) value));
            else if (value is string)
                base.Post(Reverse(value.ToString()));
            else if(int.TryParse(value.ToString(), out intVal))
                base.Post(intVal * (-1));
            else
                base.Post(value);
        }

        private static string Reverse(string value){
            var length = value.Length;
            var chs = new char[length];
            for (int i = 0; i < length; i++)
                chs[length - i] = value[i];
            return chs.ToString();
        }
    }
}