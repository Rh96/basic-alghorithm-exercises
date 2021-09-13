using System;

namespace Exercise._89
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = new int[] { 10, 20, 40, 50 };
            int[] arrayOfInts2 = new int[] { 10, 20, 40, 10 };
            int[] arrayOfInts3 = new int[] { 12, 24, 35, 55 };

            Console.WriteLine(CheckEqual(arrayOfInts));
            Console.WriteLine(CheckEqual(arrayOfInts2));
            Console.WriteLine(CheckEqual(arrayOfInts3));
            Console.ReadLine();
        }
        public static bool CheckEqual(int[] arr)
        {
            int firstElement = arr[0];
            return firstElement == arr[arr.Length - 1];
        }
    }
}
