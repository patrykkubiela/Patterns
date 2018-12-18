using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementation
{
    public class WatcherResult : ISimpleParameters
    {
        public string ValueA { get; set; }
        public string ValueB { get; set; }
        public string ValueC { get; set; }
        public string[] OtherValues { get; set; }
    }
}