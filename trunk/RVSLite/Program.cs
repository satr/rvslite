using System;
using System.Threading;

namespace RVSLite{
    internal class Program{
        private static void Main(string[] args){
            Lang.SwitchToRu();
            var sc = new ServiceCoordinator();
            sc.Subscribe();
            sc.Start();
        }
    }
}