using System;
using System.Threading;

namespace ClassLibrary_Vezba5_
{
    public class FirstSubscriber
    {
        public void SubscriberOneReceiving(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Subscriber One received this message: {message}");
        }
    }
}
