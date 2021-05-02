using System;
using System.Collections.Generic;
using System.Text;

namespace ClassL
{
    public class Dog
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark!");
        }

        public Dog()
        {

        }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public static void Validate(int id, string name, string color)
        {
            if (id != 0 && name.Length >= 2)
            {
                Console.WriteLine("Everything is under control!");
            }
            else Console.WriteLine("The dog in question does not fullfill the given standards.");
        }
    }
}
