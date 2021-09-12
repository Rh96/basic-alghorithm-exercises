using System;

namespace Exercise._82
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();


            if (str.Length > str2.Length)
            {
                Console.WriteLine("Enter a starting postion to remove characters:");
                int.TryParse(Console.ReadLine(), out int startPos);

                Console.WriteLine("Enter a number to remove chararcters from the given string:");
                int.TryParse(Console.ReadLine(), out int numOfCharToRemove);

                Console.WriteLine(str.Remove(startPos, numOfCharToRemove) + str2);
            }
            else if (str.Length < str2.Length)
            {
                Console.WriteLine("Enter a starting postion to remove characters:");
                int.TryParse(Console.ReadLine(), out int startPos);

                Console.WriteLine("Enter a number to remove chararcters from the given string:");
                int.TryParse(Console.ReadLine(), out int numOfCharToRemove);

                Console.WriteLine(str + str2.Remove(startPos, numOfCharToRemove));
            }
            else
            {
                Console.WriteLine(str + str2);
            }
            Console.ReadLine();
        }
    }
}
