using System;
using ObserverPattern.Implementation;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern");

            var watcher = new Watcher();
            
            var mailSender = new SendMail(watcher);
            var smsSender = new SendSms(watcher);
            
            watcher.GetChangedFiles();

            Console.WriteLine("Remove observer SendMail.");
            watcher.RemoveObserver(mailSender);

            Console.WriteLine("Update watcher again");
            watcher.GetChangedFiles();
            
            Console.ReadLine();
        }
    }
}