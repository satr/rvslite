using System.IO;

namespace RVSLite{
    public class Preferences{
        private static Preferences _instance;
        public string DefaultDiagramFilesPath{ set; get;}

        public Preferences(){
            DefaultDiagramFilesPath = ".";
        }

        public static Preferences Instance{
            get{
                if (_instance == null)
                    _instance = new Preferences();
                return _instance;
            }
        }
    }
}