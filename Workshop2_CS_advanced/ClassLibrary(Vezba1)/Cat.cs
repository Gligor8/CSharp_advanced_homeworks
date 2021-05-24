using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Vezba1_
{
    public class Cat : Animal
    {
        public bool isLazy { get; set; }
        public Cat(string name, int age, bool islazy) : base(name, age)
        {
            isLazy = islazy;
        }
        public void Meow()
        {
            Console.WriteLine("MEOW!!!");
        }
    }
}
