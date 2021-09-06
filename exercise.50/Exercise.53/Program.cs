using System;

namespace Exercise._53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int b);

            if(a < 10 && a > 99 || b < 10 && b > 99)
            {
                Console.WriteLine("You are out of range!");
            }

            if (a % 10 == b % 10)
            {
                Console.WriteLine((true));
            } else
            {
                Console.WriteLine((false));
            }

            Console.ReadLine();
        }
    }
}
