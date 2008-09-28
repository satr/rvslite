using System.Text.RegularExpressions;

namespace RVSLite{
    public class Settings{
        static readonly Regex _int = new Regex(@"^[\-]{0,1}\s*\d+$");
        public static object GetValueBy(string stringValue){
            string valueText = stringValue.Replace(" ", string.Empty);
            var intChecker = new IntChecker(valueText);
            if (intChecker.IsValid)
                return intChecker.Value;
            var boolChecker = new BoolChecker(valueText);
            if (boolChecker.IsValid)
                return boolChecker.Value;
            return valueText;
        }

        private class IntChecker{
            private readonly int _value;

            public IntChecker(object value){
                IsValid = false;
                if (value == null)
                    return;
                string valueText = value.ToString();
                if (!_int.IsMatch(valueText) || !int.TryParse(valueText, out _value))
                    return;
                IsValid = true;
            }

            public int Value{
                get { return _value; }
            }

            public bool IsValid { get; set; }
        }

        class BoolChecker{
            private readonly bool _value;
            public BoolChecker(object value){
                IsValid = false;
                if (value == null)
                    return;

                string lower = value.ToString().ToLower();
                foreach (
                    string text in
                        new[] {"t", "y", "true", "yes", Lang.Res.Yes.ToLower(), Lang.Res.True.ToLower(), Lang.Res.Correct.ToLower() }) {
                    if (lower == text){
                        _value = true;
                        IsValid = true;
                        return;
                    }
                }
                foreach (
                    string text in
                        new[] { "f", "n", "false", "no", Lang.Res.No.ToLower(), Lang.Res.False.ToLower(), Lang.Res.Incorrect.ToLower() }) {
                    if (lower == text){
                        _value = false;
                        IsValid = true;
                        return;
                    }
                }
            }

            public bool Value{
                get { return _value; }
            }

            public bool IsValid { get; set; }
        }

        public static bool ValueIsInt(object value){
            int intValue = 0;
            var valueText = value == null? string.Empty: value.ToString();
            return (_int.IsMatch(valueText) && int.TryParse(valueText, out intValue));
        }

        public static string ToString(object value){
            return value == null ? string.Empty : value.ToString();
        }

        public static bool GetBoolValueBy(object value){
            if (value == null)
                return false;
            var intChecker = new IntChecker(value);
            if (intChecker.IsValid)
                return intChecker.Value != 0;
            var boolChecker = new BoolChecker(value);
            if (boolChecker.IsValid)
                return boolChecker.Value;
            return !string.IsNullOrEmpty(value.ToString());
        }

        public static int GetIntValueBy(object value){
            if (value == null)
                return 0;
            var intChecker = new IntChecker(value);
            if (intChecker.IsValid)
                return intChecker.Value;
            return 0;
        }
    }
}