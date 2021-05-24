using System;

namespace ClassLibrary_Vezba1_
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
                

        }
        public void Print()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}");
        }
    }
}
