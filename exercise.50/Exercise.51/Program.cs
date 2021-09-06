using System;

namespace Exercise._51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter second number:");
            int.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine("Enter third number:");
            int.TryParse(Console.ReadLine(), out int c);

            if(Math.Abs(a - b) >= 20 || Math.Abs(a - c) >= 20 || Math.Abs(b - c) >= 20)
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
