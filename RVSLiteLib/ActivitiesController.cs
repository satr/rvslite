using System.Collections.Generic;

namespace RVSLite{
    public class ActivitiesController{
        private readonly IServiceProvider _serviceProvider;
        readonly List<ActivitiesLink> _activitiesLinks = new List<ActivitiesLink>();
        readonly List<ActivitiesLink> _startPoints = new List<ActivitiesLink>();
        public string DiagramFileName{ set; get;}
        private const int _columnCount = 100;
        private const int _rowCount = 200;

        public ActivitiesController(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
            ActivityLinksGrid = new ActivitiesLink[_columnCount, _rowCount];
        }

        private ActivitiesLink[,] ActivityLinksGrid { get; set; }

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

        public List<ActivitiesLink> ActivitiesLinks{
            get { return _activitiesLinks; }
        }

        public void AddStartPoint(ActivitiesLink activitiesLink){
            _startPoints.Add(activitiesLink);
        }

        public void PlaceLinksToGrid(){
            foreach (ActivitiesLink startPointLink in _startPoints){
                ActivityLinksGrid[100, 100] = startPointLink;
            }
        }
    }
}