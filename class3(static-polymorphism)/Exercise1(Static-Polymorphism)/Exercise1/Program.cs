using ClassL;
using System;
using System.Collections.Generic;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
               

            };

            Dog dog1 = new Dog() { Id = 433, Name = "Jackie", Color = "Grey" };
            Dog dog2 = new Dog() { Id = 523, Name = "Johny", Color = "Light-Brown" };
            Dog dog3 = new Dog() { Id = 205, Name = "Bella", Color = "Black" };

            dog1.Validate();
            dog2.Validate();
            dog3.Validate();

            dogs.Add(dog1);
            dogs.Add(dog2);
            dogs.Add(dog3);

        }
    }
}
