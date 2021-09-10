using System;

namespace Exercise._76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            if (s1.Length <= 2)
            {
                if (s1 == String.Empty)
                {
                    Console.WriteLine("##");
                }
                else
                {
                    Console.WriteLine(s1 + "#");
                }
            }
            else
            {
                Console.WriteLine(s1.Substring(0, 2));
            }

            Console.ReadLine();
        }
    }
}
