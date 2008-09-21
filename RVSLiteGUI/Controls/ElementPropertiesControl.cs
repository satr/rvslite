using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class ElementPropertiesControl : UserControl{
        public ElementPropertiesControl(){
            InitializeComponent();
        }

        public BaseActivity Value{
            set{
                lblName.Text = value.Name;
                lblValue.Visible = value.IsValueHolder;
                if (value.IsValueHolder){
                    object val = ((Variable) value).Value;
                    lblValue.Text = val == null ? "" : val.ToString();
                }
            }
        }
    }
}