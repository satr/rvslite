using System;
using System.Threading;

namespace RVSLite{
    internal class Program{
        private static void Main(string[] args){
            Lang.SwitchToRu();
            var sc = new ServiceCoordinator(null);
            sc.Subscribe();
            sc.Start();
        }
    }
}