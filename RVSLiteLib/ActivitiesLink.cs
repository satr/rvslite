namespace RVSLite{
    public class ActivitiesLink{
        private BaseActivity _sourceActivity;

        public ActivitiesLink(BaseActivity sourceActivity, BaseActivity targetActivity){
            TargetActivity = targetActivity;
            SourceActivity = sourceActivity;
        }

        public ActivitiesLink(): this(new NullActivity(), new NullActivity()){
        }

        public BaseActivity TargetActivity { get; set; }

        public BaseActivity SourceActivity {
            set {
                if (_sourceActivity != null)
                    _sourceActivity.OnPost -= TargetActivity.Post;
                _sourceActivity = value;
                if (_sourceActivity != null)
                    _sourceActivity.OnPost += TargetActivity.Post;
            }
            get {
                return _sourceActivity ?? (_sourceActivity = new NullActivity());
            }
        }

    }
}