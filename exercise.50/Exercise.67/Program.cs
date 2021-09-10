using System;

namespace Exercise._67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string s2 = Console.ReadLine();

            Console.WriteLine(s1.Substring(1) + s2.Substring(1));
            Console.ReadLine();
        }
    }
}
