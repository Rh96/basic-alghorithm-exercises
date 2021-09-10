using System;

namespace Exercise._63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            if (input.Length <= 2)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input.Substring(0, 2));
            }

            Console.ReadLine();
        }
    }
}
