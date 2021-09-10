using System;

namespace Exercise._72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckString("Hello"));
            Console.WriteLine(CheckString("Python"));
            Console.WriteLine(CheckString("On"));
            Console.WriteLine(CheckString("o"));

            Console.ReadLine();
        }

        public static bool CheckString(string s1)
        {
            return s1.Contains("On") || s1.Contains("on") || s1.Contains("ON");
        }
    }
}
