namespace RVSLite{
    public class CompositeActivityDecorator : VariableActivity{
        public CompositeActivityDecorator(BaseActivity decoratedActivity){
            InputActivity = new DataActivity();
            DecoratedActivity = decoratedActivity;
            DecoratedActivity.OnPost += base.Post;
            UseInnerActivity = true;
        }

        public BaseActivity DecoratedActivity { private set; get; }

        public VariableActivity InputActivity { get; set; }

        public bool UseInnerActivity { get; set; }

        public override void Post(object value){
            DecoratedActivity.Post(UseInnerActivity
                                   && InputActivity != null
                                   && InputActivity.Value != null
                                       ? InputActivity.Value
                                       : value);
        }
    }
}