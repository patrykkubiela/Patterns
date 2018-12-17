namespace ObserverPattern.Interfaces
{
    public interface ISimpleObservable
    {
        void AddObserver(ISimpleObserver observer);
        void RemoveObserver(ISimpleObserver observerToRemove);
        void UpdateState();
    }
}