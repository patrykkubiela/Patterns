using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementation
{
    public class SendMail : ISimpleObserver, ISend
    {
        public SendMail(ISimpleObservable observed)
        {
            observed.AddObserver(this);
        }
        
        public void OnUpdate(ISimpleParameters parameters)
        {
            var message = string.Join(", ", parameters.OtherValues);
            Send($"SendMail: {message}");
        }

        public void Send(string message)
        {
            //fake implementation
            Console.WriteLine(message);
        }
    }
}