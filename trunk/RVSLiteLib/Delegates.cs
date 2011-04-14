namespace RVSLite{
    public delegate void ActivityEventHandler(BaseActivity activity);
    public delegate void LinkedActivitiesEventHandler(BaseActivity sourceActivity, BaseActivity targetActivity);
    public delegate void VariableActivityEventHandler(VariableActivity variableActivity);

    public delegate void ValueEventHandler(object value);

    public delegate void ActionEventHandler();
}