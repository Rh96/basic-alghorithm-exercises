using System;

namespace Execise._80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            if (s1.StartsWith("abc"))
            {
                Console.WriteLine("abc");
            }
            else if (s1.StartsWith("xyz"))
            {
                Console.WriteLine("xyz");
            }
            else
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
