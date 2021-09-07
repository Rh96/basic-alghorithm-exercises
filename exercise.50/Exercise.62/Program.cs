using System;

namespace Exercise._62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            string newString = s1.Substring(s1.Length - 2);

            Console.WriteLine(newString + newString + newString);
            Console.ReadLine();
        }
    }
}
