using System;

namespace Exercise._83
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            if (str.Length <= 2)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine(str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2));
            }

            Console.ReadLine();
        }
    }
}
