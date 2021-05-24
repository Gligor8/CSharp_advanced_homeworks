using System;

namespace ClassLibrary_Vezba2_
{
    public static class ClassOfMethods
    {
        // First Letter of a string
        public static void GetFirstLetter(this string str, string substr)
        {
            substr = str.Substring(0, 1);
            Console.WriteLine(substr);
        }

        // Last Letter of a string

        public static void LastLetter(this string str1, string substr1)
        {
            substr1 = str1.Substring(str1.Length - 1);
            Console.WriteLine(substr1);
        }

        // Is even

        public static void IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }

        // N from a list

        public static int GetNfromList(List<T> list) where T : BaseEntity
        {
            foreach (int N in list)
            {
                return list.N[0];
            }
        }
        Console.WriteLine(GetNfromList);

        



    }
}
