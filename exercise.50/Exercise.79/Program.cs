using System;

namespace Exercise._79
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            // h e l l o
            // 0 1 2 3 4
            string lastChar = s1.Substring(s1.Length - 1); // o
            char lastCharSecond = s1[s1.Length - 2];
            string getRestOfTheText = s1.Remove(s1.Length - 2); // hel

            Console.WriteLine(getRestOfTheText + lastChar + lastCharSecond);
            Console.ReadLine();
        }
    }
}
