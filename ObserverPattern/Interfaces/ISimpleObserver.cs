namespace ObserverPattern.Interfaces
{
    public interface ISimpleObserver
    {
        void OnUpdate(ISimpleParameters parameters);
    }
}