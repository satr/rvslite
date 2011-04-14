using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls {
    public partial class CompositeActivityControl : UserControl, IActivityControl {
        private CompositeActivity _activity;

        public CompositeActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Activity;
            btnOpen.Click += btnOpen_Click;
        }

        void btnOpen_Click(object sender, EventArgs e) {
            MainController.Instance.OpenCompositeActivityFor((CompositeActivity)Activity);
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set { _activity = (CompositeActivity) value; }
        }

        #endregion
        private BaseActivity _sourceActivity = new NullActivity();
        public BaseActivity SourceActivity {
            get { return _sourceActivity; }
            set { _sourceActivity = value; }
        }

        public event ActivityControlEventHandler OnClickActivityControl;

        public Color DefaultBGColor { get; set; }

        public bool Selected { get; set; }

        public void Init() {
            ActivityControlsController.InitControlBy(this, groupBox);
            FireOnClickActivityControl();
        }

        public void FireOnClickActivityControl() {
            if (OnClickActivityControl != null)
                OnClickActivityControl(this);
        }
    }
    }

