using System;

namespace Exercise._77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string s2 = Console.ReadLine();

            if (s2.Length == 0)
            {
                Console.WriteLine(s1 + "#");
            }
            else if (s1.Length == 0)
            {
                Console.WriteLine("#" + s2);
            }
            else
            {
                Console.WriteLine(s1.Substring(0, 1) + s2.Substring(s2.Length - 1));
            }
            Console.ReadLine();
        }
    }
}
