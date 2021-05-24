using System;

namespace ClassLibrary_Vezba1_
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age
        {
            get;
           
            set
            {
                if (Age < 0 || Age > 175)
                {
                    Console.WriteLine("Error numbers");
                    
                }
                
            }
        }

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
