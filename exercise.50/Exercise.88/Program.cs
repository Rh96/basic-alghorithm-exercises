using System;

namespace Exercise._88
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfInts = new int[]  { 10, 20, 40, 50 };
            int[] arrOfInts2 = new int[] { 5, 20, 40, 10 };
            int[] arrOfInts3 = new int[] { 10, 20, 40, 10 };
            int[] arrOfInts4 = new int[] { 12, 24, 35, 55 };

            Console.WriteLine(CheckInt(arrOfInts));
            Console.WriteLine(CheckInt(arrOfInts2));
            Console.WriteLine(CheckInt(arrOfInts3));
            Console.WriteLine(CheckInt(arrOfInts4));
            Console.ReadLine();
        }

        public static bool CheckInt(int[] arr)
        {
            bool temp = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 10 || arr[arr.Length - 1] == 10)
                {
                    temp = !temp;
                    break;
                }
            }
            return temp;
        }
    }
}
