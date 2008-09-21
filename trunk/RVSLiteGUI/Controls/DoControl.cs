using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RVSLite.Controls {
    public partial class DoControl : UserControl {
        private BaseActivity _activity;

        public DoControl() {
            InitializeComponent();
        }

        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = value;
                groupBox.Text = _activity.Name;
            }
        }
    }
}
