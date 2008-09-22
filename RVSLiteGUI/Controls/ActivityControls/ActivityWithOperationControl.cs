using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class ActivityWithOperationControl : UserControl, IActivityControl{
        private ActivityWithOperation _activity;
        private IServiceProvider _serviceProvider;

        public ActivityWithOperationControl(){
            InitializeComponent();
        }

        public string ControlName{
            set { groupBox.Text = value; }
        }

        public IServiceProvider ServiceProvider{
            set{
                _serviceProvider = value;
                variableOrDataControl.Variables = _serviceProvider.Variables;
            }
        }

        public IEnumerable<OperationsCommandBase> OperationCommands{
            set { cbOperationCommands.DataSource = new List<OperationsCommandBase>(value); }
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get{
                _activity.InitBy((OperationsCommandBase) cbOperationCommands.SelectedValue,
                                 variableOrDataControl.SelectedActivity);
                return _activity;
            }
            set{
                _activity = (ActivityWithOperation) value;
                lblSource.Text = _activity.SourceActivity.Name;
            }
        }

        #endregion
    }
}