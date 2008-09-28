namespace RVSLite{
    public class ActivitiesLink{
        private BaseActivity _sourceActivity;
        private readonly BaseActivity _targetActivity;

        public ActivitiesLink(BaseActivity sourceActivity, BaseActivity targetActivity){
            _targetActivity = targetActivity;
            SourceActivity = sourceActivity;
        }

        public BaseActivity TargetActivity{
            get { return _targetActivity; }
        }

        public BaseActivity SourceActivity {
            set {
                if (_sourceActivity != null)
                    _sourceActivity.OnPost -= _targetActivity.Post;
                _sourceActivity = value;
                if (_sourceActivity != null)
                    _sourceActivity.OnPost += _targetActivity.Post;
            }
            get {
                return _sourceActivity ?? (_sourceActivity = new NullActivity());
            }
        }

    }
}