using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite{
    public delegate void SetTextCallback(string text);

    public delegate void SetEnabledCallback(bool value);
    
    public class ControlCallback {
        private readonly Form _form;
        private readonly Control _control;
        private static readonly Dictionary<string, ControlCallback> _dict = new Dictionary<string, ControlCallback>();

        private ControlCallback(Form form, Control control) {
            _form = form;
            _control = control;
        }

        public static void SetTextFor(Form form, Control control, string text) {
            GetControlCallbackFor(form, control).SetText(text);
        }

        public static void AppendTextFor(Form form, TextBox textBox, string text) {
            GetControlCallbackFor(form, textBox).AppendText(text);
        }

        private static ControlCallback GetControlCallbackFor(Form form, Control control){
            string key = GetKeyFor(form, control);
            if(!_dict.ContainsKey(key))
                _dict.Add(key,new ControlCallback(form, control));
            return _dict[key];
        }

        private static string GetKeyFor(Form form, Control control){
            return string.Format("{0}_{1}", form.GetHashCode(), control.GetHashCode());
        }

        public static void SetEnabledFor(Form form, Control control, bool enabled) {
            new ControlCallback(form, control).SetEnabled(enabled);
        }

        private void SetText(string text) {
            if (_control.InvokeRequired)
                _form.Invoke(new SetTextCallback(SetText), new object[] { text });
            else
                _control.Text = text;
        }

        private void AppendText(string text) {
            if (_control.InvokeRequired)
                _form.Invoke(new SetTextCallback(AppendText), new object[] { text });
            else
                ((TextBox)_control).AppendText(text);
        }

        private void SetEnabled(bool enabled) {
            if (_control.InvokeRequired)
                _form.Invoke(new SetEnabledCallback(SetEnabled), new object[] { enabled });
            else
                _control.Enabled = enabled;
        }
    }
}