using ClassLibrary_Vezba5_;
using System;

namespace Vezba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer johnny = new Trainer();
            FirstSubscriber subsc1 = new FirstSubscriber();
            SecondSubscriber subsc2 = new SecondSubscriber();
            ThirdSubscriber subsc3 = new ThirdSubscriber();

            johnny.stringDelegateHandler += subsc1.SubscriberOneReceiving;
            johnny.stringDelegateHandler += subsc2.SubscriberTwoReceiving;
            johnny.stringDelegateHandler += subsc3.SubscriberThreeReceiving;

            johnny.ComposeMessage("Kristina", 4, "Skipping workshops is for losers!");

            Console.ReadLine();
        }
    }
}
