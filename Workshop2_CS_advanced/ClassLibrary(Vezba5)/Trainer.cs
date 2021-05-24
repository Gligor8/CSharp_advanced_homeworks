using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassLibrary_Vezba5_
{ public delegate void stringDelegate(string note);
    public class Trainer
    {
        public event stringDelegate stringDelegateHandler;
        public void SendMessage(string message)
        {
            stringDelegateHandler?.Invoke(message);
        }

        public virtual void ComposeMessage(string trainerName, int groupNumber, string message)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Sending message...");
            SendMessage($"{trainerName} informs G{groupNumber}: {message}");
        }

    }
}
