using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Vezba1_
{
    public class Bird : Animal
    {
        public bool isWild { get; set; }
        public Bird(string name, int age, bool iswild) : base(name, age)
        {
            isWild = iswild;
        }

        public void FlySouth()
        {
            if (isWild == true)
            {
                Console.WriteLine("Yes, it flies South.");
            }
            else if (isWild == false)
            {
                Console.WriteLine("No, it is a domesticated bird.");
            }
        }

        public static explicit operator Bird(List<Bird> v)
        {
            throw new NotImplementedException();
        }
    }
}
