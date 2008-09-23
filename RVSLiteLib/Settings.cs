using System.Text.RegularExpressions;

namespace RVSLite{
    public class Settings{
        static readonly Regex _int = new Regex(@"^[\-]{0,1}\s*\d+$");
        public static object GetValueBy(string stringValue){
            string valueText = stringValue.Replace(" ", string.Empty);
            int intValue = 0;
            if (_int.IsMatch(valueText) && int.TryParse(valueText, out intValue))
                return intValue;
            string lower = valueText.ToLower();
            foreach (
                string text in
                    new[]{"true", Lang.Res.Yes.ToLower(), Lang.Res.True.ToLower(), Lang.Res.Correct.ToLower()}){
                if (lower == text)
                    return true;
            }
            foreach (
                string text in
                    new[]{"false", Lang.Res.No.ToLower(), Lang.Res.False.ToLower(), Lang.Res.Incorrect.ToLower()}){
                if (lower == text)
                    return false;
            }
            return valueText;
        }
    }
}