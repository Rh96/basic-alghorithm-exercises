using System;

namespace Exercise._56
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


            if (a == 13)
            {
                Console.WriteLine(a);
            } 
            else if (b == 13)
            {
                Console.WriteLine(a);
            }
            else if (c == 13)
            {
                Console.WriteLine("{0}", a + b);
            }
            else
            {
                Console.WriteLine("{0}", a + b + c);
            }
            Console.ReadLine();
        }
    }
}
