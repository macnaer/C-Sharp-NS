using System;

namespace _02._methods_arrays_string
{
    class Program
    {
        //ref  - передача пареметру по посиланню (має бути ініціалізованим)
        // out - передача пареметру по посиланню
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Swap : {a} {b}");
        }

        static void Sum(int a, int b, out int result)
        {
            result = a + b;
        }

        static void Main(string[] args)
        {
            // Example 1
            //int one = 10, second = 20;
            //Swap(ref one, ref second);
            //Console.WriteLine($"Main : {one} {second}");

            // Example 2
            //int a, b, result;
            //Console.WriteLine("Enter fitst number: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Sum(a, b, out result);
            //Console.WriteLine($"Sum = {result}");

            // Example 3
            //int[] arr = { 4, 5, 7, 1 };
            //Console.WriteLine($"Total elements => {arr.Length}");

            // Example 3

            // https://docs.microsoft.com/en-us/dotnet/api/system.array?view=net-5.0
            //int SIZE;
            //Console.WriteLine("Enter array size: ");
            //while (!int.TryParse(Console.ReadLine(), out SIZE))
            //{
            //    Console.WriteLine("Wrong size! Try again. ");
            //}

            //int[] arr = new int[SIZE]; // arr(stack) ----->>> Heap[][][][][]
            //Fill(arr, 10, 20);
            //Print(arr);

            // Example 4 (потрібен int[] arr = { 4, 5, 7, 1 };)
            //int[] cloneArr = (int[])arr.Clone();
            //Print(cloneArr);
            //Console.WriteLine($"Different TRUE => {!ReferenceEquals(arr, cloneArr)}");

            // Example 5 (Багатовимірні масиви)

            //int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6, } };
            //for(int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{ matrix[i, j] }");
            //    }
            //    Console.WriteLine();
            //}

            // Example 5 Jagged (Зубчасті)

            int [][] jaggedArr = new int[4][];
            jaggedArr[0] = new int[2];
            jaggedArr[1] = new int[4];
            jaggedArr[2] = new int[3];
            jaggedArr[3] = new int[5];

            Console.WriteLine("Enter array values: ");

            for(int i = 0; i < jaggedArr.Length; i++)
            {
                for(int j =0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j]} ");

                }
                Console.WriteLine();
            }
        }

        private static void Print(int[] arr)
        {
            foreach (var el in arr) { // Тільки для читання елементів масиву(колекцій)
                Console.Write($"{el}\t");
            }
            Console.WriteLine();
        }

        private static void Fill(int[] arr, int start, int end)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(start, end + 1);
            }
        }
    }
}
