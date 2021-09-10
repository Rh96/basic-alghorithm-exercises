using System;

namespace Exercise._70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            if (s1.Length <= 2)
            {
                Console.WriteLine(String.Empty);
            }
            else
            {
                Console.WriteLine(s1.Substring(1, s1.Length - 2));
            }
            Console.ReadLine();
        }
    }
}
