﻿namespace RVSLite{
    public class Drive : BaseActivity{
        private static int _instanceCounter;
        public static readonly string OperatorName = Lang.Res.Drive;
        private string _name;

        public Drive()
            : this(string.Format("{0}#{1}", OperatorName, _instanceCounter++)){
        }

        public Drive(string name){
            _name = name;
        }

        public override string Name{
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString(object value){
            var directionValue = ((int) value);
            string direction = directionValue < 0
                                   ? Lang.Res.RunBackward
                                   : (directionValue > 0
                                          ? Lang.Res.RunForward
                                          : Lang.Res.Stopped);
            return string.Format("{0}: {1}", Name, direction);
        }
    }
}