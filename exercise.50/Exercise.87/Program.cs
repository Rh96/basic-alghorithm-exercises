using System;

namespace Exercise._87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            if (str.Substring(0, 1) == "a" && str.Substring(1, 1) == "a")
            {
                Console.WriteLine(str.Remove(0, 2));
            }
            else
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
