using System;

namespace _08._Generic
{
    class Program
    {
        static void Print<T>(T[] arr)
        //static void Print<T>(T[] arr) where T : class
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string[] words = { "Bill", "Tom", "Adam" };
            Print(words);


            //int[] numbers = { 5, 2, 7, 45, 23 };
            //Print(numbers);
        }
    }
}
