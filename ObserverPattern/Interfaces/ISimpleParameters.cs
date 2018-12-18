namespace ObserverPattern.Interfaces
{
    public interface ISimpleParameters
    {
        string ValueA { get; set; }
        string ValueB { get; set; }
        string ValueC { get; set; }
        string[] Values { get; set; }
    }
}