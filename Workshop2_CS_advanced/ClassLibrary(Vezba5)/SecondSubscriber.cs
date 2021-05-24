using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassLibrary_Vezba5_
{
    public class SecondSubscriber
    {
        public void SubscriberTwoReceiving(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Subscriber Two received this message: {message}");
        }
    }
}
