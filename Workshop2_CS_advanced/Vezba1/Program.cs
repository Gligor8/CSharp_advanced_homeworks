using ClassLibrary_Vezba1_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Vezba1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Jackie", 3, "pitbull"),
                new Dog("Flaffy", 4, "chiuaua"),
                new Dog("Zack", 6, "pitbull"),
            };

            List<Cat> cats = new List<Cat>()
            {
                new Cat("Catas", 1, true),
                new Cat("Tipsi", 3, false),
                new Cat("Zack", 5, true),
            };

            List<Bird> birds = new List<Bird>()
            {
                new Bird("Ziggy", 1, true),
                new Bird("Malau", 1, false),
                new Bird("Trapy", 5, false),
            };

            Dog particularBreed = (Dog)dogs
                .Select(x => x.Breed == "pitbull");
            Console.WriteLine(particularBreed);

            Cat lastLazyCat = (Cat)cats
                .Where(x => x.isLazy == true)
                .Last();
            Console.WriteLine(lastLazyCat);


            Bird wildBirdsUnder3 = (Bird)birds
                            .Where(x => x.Age < 3)
                            .Where(x => x.isWild == true)
                            .OrderBy(x => x.Name)
                            .ToList();
            Console.WriteLine(wildBirdsUnder3);

            Console.ReadLine();
        }
    }
}
