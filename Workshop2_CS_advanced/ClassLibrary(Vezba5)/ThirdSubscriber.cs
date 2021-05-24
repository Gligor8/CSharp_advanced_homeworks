using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassLibrary_Vezba5_
{
    public class ThirdSubscriber
    {
        public void SubscriberThreeReceiving(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Subscriber Three received this message: {message}");
        }
    }
}
