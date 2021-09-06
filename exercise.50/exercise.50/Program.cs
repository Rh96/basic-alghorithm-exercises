using System;

namespace exercise._50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter second number: ");
            int.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine("Enter third number: ");
            int.TryParse(Console.ReadLine(), out int c);

            if (a <= 0 && b <= 0 && c <= 0)
            {
                Console.WriteLine("Enter positive number!");
            }

            Console.WriteLine(Program.CheckRightmostDigit(a, b, c));
            Console.WriteLine(Program.CheckRightmostDigit(11, 21, 33));
            Console.WriteLine(Program.CheckRightmostDigit(11, 22, 33));
            Console.ReadLine();
        }

        static bool CheckRightmostDigit(int num, int num2, int num3)
        {
            return
                num % 10 == num2 % 10 ||
                num % 10 == num3 % 10 ||
                num2 % 10 == num3 % 10;
        }
    }
}
