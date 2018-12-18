using System.Collections.Generic;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementation
{
    public class Watcher : ISimpleObservable
    {
        private List<ISimpleObserver> observers;
        private ISimpleParameters parameters;

        public Watcher()
        {
            observers = new List<ISimpleObserver>();
        }

        public void GetChangedFiles()
        {
            //fake implementation just for call architectual mechanism
            parameters = new WatcherResult();
        }

        public void AddObserver(ISimpleObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(ISimpleObserver observerToRemove)
        {
            observers.Remove(observerToRemove);
        }

        public void UpdateState()
        {
            foreach (var observer in observers)
            {
                observer.OnUpdate(parameters);
            }
        }
    }
}