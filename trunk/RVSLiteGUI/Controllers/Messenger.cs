using System;
using System.Text;
using System.Windows.Forms;

namespace RVSLite{
    public class Messenger{
        public static void ShowError(Exception ex, string format, params object[] args){
            var builder = new StringBuilder();
            builder.AppendLine(string.Format(format, args));
            while(ex != null){
                builder.AppendLine(ex.Message);
                ex = ex.InnerException;
            }
            MessageBox.Show(builder.ToString(), Lang.Res.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowError(string format, params object[] args){
            ShowError(null, format, args);
        }

        public static bool ShowConfirmation(string format, params object[] args){
            return MessageBox.Show(string.Format(format, args), Lang.Res.Confirmation, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
        }
    }
}