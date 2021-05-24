using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Vezba1_
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public void Bark()
        {
            Console.WriteLine("BARK, BARK!!!");
        }

        public class PrintList
        {
        }
    }
}
