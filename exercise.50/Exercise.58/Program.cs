using System;

namespace Exercise._58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter second number:");
            int.TryParse(Console.ReadLine(), out int b);

            if(a > 13 || b > 13)
            {
                Console.WriteLine(0);
            }
            
            else if (13 - a > 13 - b)
            {
                Console.WriteLine(a);
            }
            
            else if (13 - b > 13 - a)
            {
                Console.WriteLine(b);
            }

            Console.ReadLine();
        }
    }
}
