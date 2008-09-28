using System.Collections.Generic;

namespace RVSLite{
    public class ActivitiesController{
        private readonly IServiceProvider _serviceProvider;
        readonly List<ActivitiesLink> _activitiesLinks = new List<ActivitiesLink>();
            
        public ActivitiesController(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
        }

        public IServiceProvider ServiceProvider{
            get { return _serviceProvider; }
        }


        public void RegisterActivity(BaseActivity sourceActivity, BaseActivity targetActivity){
            _activitiesLinks.Add(new ActivitiesLink(sourceActivity, targetActivity));
        }

        public void UnregisterActivity(BaseActivity activity){
            foreach (ActivitiesLink activitiesLink in new List<ActivitiesLink>(_activitiesLinks)){
                if(activitiesLink.TargetActivity == activity)
                    _activitiesLinks.Remove(activitiesLink);
                if (activitiesLink.SourceActivity == activity)
                    activitiesLink.SourceActivity = null;
            }
        }
    }
}