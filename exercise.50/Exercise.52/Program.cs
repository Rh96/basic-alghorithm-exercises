using System;

namespace Exercise._52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter second number:");
            int.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(CheckLargerInteger(a, b));
            Console.WriteLine(CheckLargerInteger(11, 20));
            Console.WriteLine(CheckLargerInteger(24, 10));
            Console.WriteLine(CheckLargerInteger(10, 10));

            Console.ReadLine();
        }

        public static int CheckLargerInteger(int num, int num2)
        {
            if (num == num2) return 0;
            if (num % 7 == num2 % 7) return (num < num2) ? num : num2;
            return (num > num2) ? num : num2;
        }
    }
}
