using System;

namespace Exercise._54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter second number:");
            int.TryParse(Console.ReadLine(), out int b);

            int sum = 0;
            sum = a + b;

            int countDigitA = CountDigit(a);
            int countDigitB = CountDigit(b);
            int countDigitSum = CountDigit(sum);

            if (countDigitSum == countDigitA)
            {
                Console.WriteLine(sum);
            }
            else if (countDigitSum > countDigitA)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }

        public static int CountDigit(int n)
        {
            int countDigit = 0;
            while(n != 0)
            {
                n = n / 10;
               countDigit++;
            }

            return countDigit;
        }
    }
}
