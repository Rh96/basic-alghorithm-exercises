using System;

namespace Exercise._55
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

            if (a == b)
            {
                Console.WriteLine(c);
            } else
            {
                Console.WriteLine("{0}", a + b + c);
            }

            Console.ReadLine();
        }
    }
}
