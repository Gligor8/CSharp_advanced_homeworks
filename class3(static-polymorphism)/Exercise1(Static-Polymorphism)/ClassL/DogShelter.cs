using System;
using System.Collections.Generic;

namespace ClassL
{
    static class DogShelter
    {
        public static List<Dog> ListOfDogs { get; set; }

        public static void PrintAll()
        {
            Console.WriteLine(ListOfDogs);
        }
    }
}
