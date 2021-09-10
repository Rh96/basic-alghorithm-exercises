using System;

namespace Exercise._68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            string firstTwoChars = s1.Substring(0, 2);
            string newString = s1.Substring(2) + firstTwoChars;

            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}