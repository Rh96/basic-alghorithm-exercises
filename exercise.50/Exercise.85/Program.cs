using System;

namespace Exercise._85
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            // a b c a t
            if (str.Substring(0, 1) != "p" && str.Substring(1, 1) != "y")
            {
                Console.WriteLine(str.Remove(0, 2));
            }
            else if (str.Substring(0, 1) != "p")
            {
                Console.WriteLine(str.Remove(0, 1));
            }
            else if (str.Substring(1, 1) != "y")
            {
                Console.WriteLine(str.Remove(1, 1));
            }
            else
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
