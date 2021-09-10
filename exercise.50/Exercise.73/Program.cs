using System;

namespace Exercise._73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter a num of characters:");
            int.TryParse(Console.ReadLine(), out int numOfChar);

            // h e l l o
            // 0 1 2 3 4
            string firstChar = s1.Substring(0, numOfChar);
            string lastChar = s1.Substring(s1.Length - numOfChar);

            Console.WriteLine(firstChar + lastChar);
            Console.ReadLine();
        }
    }
}
