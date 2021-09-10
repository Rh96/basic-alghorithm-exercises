using System;

namespace Exercise._69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();

            string lastTwoChar = s1.Substring(s1.Length - 2);

            if (s1.Length <= 2)
            {
                Console.WriteLine(s1);
            }
            else
            {
                Console.WriteLine(lastTwoChar + s1.Remove(s1.Length - 2));
            }

            Console.ReadLine();
        }
    }
}
