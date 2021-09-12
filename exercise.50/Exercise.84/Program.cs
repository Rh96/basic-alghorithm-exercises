using System;

namespace Exercise._84
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            if (str.Substring(0, 2) == str.Substring(str.Length - 2))
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
