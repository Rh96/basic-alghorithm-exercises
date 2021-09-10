using System;

namespace Exercise._75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();
            // a b c
            // 0 1 2 3 4
            
            if (s1.Length > 3)
            {
                Console.WriteLine(s1.Substring(1, 3));
            }
            else
            {
                Console.WriteLine(s1);
            }
            Console.ReadLine();
        }
    }
}
