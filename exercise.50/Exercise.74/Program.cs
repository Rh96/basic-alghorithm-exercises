using System;

namespace Exercise._74
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter a starting position from the given string:");
            int.TryParse(Console.ReadLine(), out int startPos);

            Console.WriteLine(s1.Substring(startPos, 2));
            Console.ReadLine();
        }
    }
}
