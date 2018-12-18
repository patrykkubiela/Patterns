using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementation
{
    public class SendSms : ISimpleObserver, ISend
    {
        public SendSms(ISimpleObservable observed)
        {
            observed.AddObserver(this);
        }
        
        public void OnUpdate(ISimpleParameters parameters)
        {
            Send($"SendSMS: {parameters.ValueA} {parameters.ValueB} {parameters.ValueC}");
        }

        public void Send(string message)
        {
            //fake implementation
            Console.WriteLine(message);
        }
    }
}