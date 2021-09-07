using System;

namespace Exercise._57
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


            if (a >= 10 && a <= 20)
            {
                if(a == 13 || a == 17)
                {
                    Console.WriteLine(a);
                } 
                else
                {
                    Console.WriteLine(0);
                }
            }
            else if (b >= 10 && b <= 20)
            {
                if (b == 13 || b == 17)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            else if (c >= 10 && c <= 20)
            {
                if (c == 13 || c == 17)
                {
                    Console.WriteLine("{0}", a + b);
                }
            }
            else
            {
                Console.WriteLine("{0}", a + b + c);
            }

            Console.ReadLine();
        }
    }
}
