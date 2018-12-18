using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementation
{
    public class SendSms : ISimpleObserver, ISend
    {
        public void OnUpdate(ISimpleParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public void Send()
        {
            throw new System.NotImplementedException();
        }
    }
}