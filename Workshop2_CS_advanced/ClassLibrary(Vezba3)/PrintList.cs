using System;
using System.Collections.Generic;

namespace ClassLibrary_Vezba3_
{
    public class PrintList<T> where T : PrintListBase
    {
        public List<T> lista;

        public PrintList()
        {
            Console.WriteLine(lista);
        }

        public void PrintListItems()
        {
            foreach (T item in lista)
            {
                Console.WriteLine(item);
            }
        }


    }
}
