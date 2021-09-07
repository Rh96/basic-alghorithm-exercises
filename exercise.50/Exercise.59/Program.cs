using System;

namespace Exercise._59
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


            if (AbsoluteNumber(a - b) == AbsoluteNumber(b - c))
            {
                Console.WriteLine((true));
            } 
            else
            {
                Console.WriteLine((false));
            }
            Console.ReadLine();
        }

        public static int AbsoluteNumber(int n)
        {
            return n * -1;
        }
    }
}
