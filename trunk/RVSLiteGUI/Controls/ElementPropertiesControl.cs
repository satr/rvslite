using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class ElementPropertiesControl : UserControl{
        public ElementPropertiesControl(){
            InitializeComponent();
        }

        public BaseOperator Value{
            set{
                lblName.Text = value.Name;
                lblValue.Visible = value.IsValueHolder;
                if (value.IsValueHolder){
                    object val = ((ValueHolder) value).Value;
                    lblValue.Text = val == null ? "" : val.ToString();
                }
            }
        }
    }
}