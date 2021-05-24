using System;

namespace Vezba4
{
    class Program
    {
        public delegate bool TwoStringsBoolDelegate(string username, string password);
        static void Main(string[] args)
        {

            Func<string, string, bool> LenthOfStringsCompare = (username, password) => username.Length > password.Length;
            Func<string, string, bool> StartingCharachter = (username, password) => username[0] == password[0];

            TwoStringsBoolDelegate DLenthOfStringsCompare = new TwoStringsBoolDelegate(LenthOfStringsCompare);
            TwoStringsBoolDelegate DStartingCharachter = new TwoStringsBoolDelegate(StartingCharachter);

            StringMagic("Ranchy5", "todo44", DStartingCharachter);
            StringMagic("Farrel24", "gogo55", DStartingCharachter);

            Console.ReadLine();
        }


        public static void StringMagic(string username, string password, TwoStringsBoolDelegate delegator)
        {
            Console.WriteLine($"Username: {username} and Password: {password}");
            Console.WriteLine(delegator (username ,password));
           
        }


        
    }
}
