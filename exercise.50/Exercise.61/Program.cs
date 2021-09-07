using System;

namespace Exercise._61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string s2 = Console.ReadLine();

            Console.WriteLine(s1.Insert(s1.Length / 2, s2));
            Console.ReadLine();
        }
    }
}
