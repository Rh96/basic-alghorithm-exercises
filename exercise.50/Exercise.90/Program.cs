using System;

namespace Exercise._90
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 40, 50 };
            int[] arr2 = new int[] { 10, 20, 40, 50 };
            int[] arr3 = new int[] { 10, 20, 40, 50 };
            int[] arr4 = new int[] { 10, 20, 40, 5 };
            int[] arr5 = new int[] { 10, 20, 40, 50 };
            int[] arr6 = new int[] { 1, 20, 40, 5 };

            Console.WriteLine(CompareTwoArrays(arr, arr2));
            Console.WriteLine(CompareTwoArrays(arr3, arr4));
            Console.WriteLine(CompareTwoArrays(arr5, arr6));
            Console.ReadLine();
        }

        public static bool CompareTwoArrays(int[] arr, int[] arr2)
        {
            int firsArrElement = arr[0];
            int secondArrElement = arr2[0];
            int lastArrElement = arr[arr.Length - 1];
            int lastSecArrElement = arr2[arr.Length - 1];

            return firsArrElement == secondArrElement || lastArrElement == lastSecArrElement;
        }
    }
}
