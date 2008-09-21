using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class ElementPropertiesControl : UserControl{
        public ElementPropertiesControl(){
            InitializeComponent();
        }

        public BaseActivity Value{
            set{
                lblName.Text = value.Name;
                lblValue.Visible = value.IsVariable;
                if (value.IsVariable){
                    object val = ((VariableActivity) value).Value;
                    lblValue.Text = val == null ? "" : val.ToString();
                }
            }
        }
    }
}