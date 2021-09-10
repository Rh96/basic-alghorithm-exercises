using System;

namespace Exercise._78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string s2 = Console.ReadLine();

            if (s1.Substring(s1.Length - 1) == s2.Substring(0, 1))
            {
                Console.WriteLine(s1+s2.Substring(1));
            }
            else
            {
                Console.WriteLine(s1+s2);
            }
            Console.ReadLine();
        }
    }
}
