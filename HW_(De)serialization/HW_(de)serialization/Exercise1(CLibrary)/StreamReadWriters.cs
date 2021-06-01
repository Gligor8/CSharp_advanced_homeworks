using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercise1_CLibrary_
{
    public class StreamReadWriters
    {
        public string ReadingFiles(string path)
        {
            string result = "";
            if (!File.Exists(path))
            {
                return "File not in existance!";
            }
            using (StreamReader sr = new StreamReader(path, true))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine("File read!");
            return result;
        }
        public void WritingFiles(string path, string data)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("File written!");
        }
    }
}
