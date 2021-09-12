using System;

namespace Exercise._81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            if (str.Substring(0, 2) == str.Substring(str.Length - 2))
            {
                Console.WriteLine((true));
            }
            else
            {
                Console.WriteLine((false));
            }

            Console.ReadLine();
        }
    }
}
