using System;

namespace Exercise._65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
                                                
            Console.WriteLine(input.Substring(1).Substring(0, input.Length - 2));
            Console.ReadLine();
        }
    }
}
