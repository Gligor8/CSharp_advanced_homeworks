using Exercise1_CLibrary_;
using System;
using Newtonsoft.Json;
using System.IO;

namespace HW__de_serialization_Exercise1
{
    class Program
    {
        static string PathToDirectory = @"..\..\..\JsonData";
        static string fileDirc = PathToDirectory + @"\JsonFile.json";
        static StreamReadWriters streamReWr = new StreamReadWriters();
        static void Main(string[] args)
        {
            if (!Directory.Exists(PathToDirectory)) Directory.CreateDirectory(PathToDirectory);

            Console.WriteLine("Enter your dog's name:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter your dog's age:");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your dog's color:");
            string color1 = Console.ReadLine();

            

            Dog doggy = new Dog()
            {
                Name = name1,
                Age = age1,
                Color = color1
            };

            string serializedDog = JsonConvert.SerializeObject(doggy);
            Console.WriteLine(serializedDog);

            Dog deserializedDog = JsonConvert.DeserializeObject<Dog>(serializedDog);
            Console.WriteLine(deserializedDog);
               
            

            Console.ReadLine();
        }
    }
}
