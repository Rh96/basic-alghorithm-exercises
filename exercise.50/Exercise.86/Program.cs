using System;

namespace Exercise._86
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            if (str[0] == 'a' || str.Length - 1 == 'a')
            {
                // a b c d a
                string temp = string.Empty;
                temp = str.Remove(0, 1);
                Console.WriteLine(temp.Remove(temp.Length - 1));
            }
            else
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
