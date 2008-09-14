namespace RVSLite{
    public interface IHardwareInterface{
        ITriggerValue Bumper1 { get; }
        ITriggerValue Led1 { get; }
    }
}