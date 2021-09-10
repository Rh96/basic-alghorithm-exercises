using System;

namespace Exercise._71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            // h e l l o
            // 0 1 2 3 4
            Console.WriteLine(s1.Substring(1,2));
            Console.ReadLine();
        }
    }
}
