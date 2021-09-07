using System;

namespace Exercise._60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first word:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter your second word:");
            string s2 = Console.ReadLine();

            Console.WriteLine(s1+s2+s2+s1);
            Console.ReadLine();
        }
    }
}
