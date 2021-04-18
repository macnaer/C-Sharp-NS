using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        // collection generic<> and nonegeneric(object)
        static void Main(string[] args)
        {
            // Example 1
            //ArrayList arr = new ArrayList(10); // Object
            //arr.Add("Hello");
            //arr.AddRange(new int [] { 4, 4, 8, 4, 5, 9, 1 });
            //Print(arr, "Before insert");
            //arr.InsertRange(2, new double[] { 4.6, 34.7, 103, 9 });
            //Print(arr, "After insert");

            List<string> list = new List<string>() { "London", "Rivne", "Berlin", "Paris" };
            Stack<string> stack = new Stack<string>();
            stack.Push("NY");
            stack.Push("LA");
            list.InsertRange(1, stack);

            Print(list, "List<Stack>");
           
        }

        static void Print(IEnumerable arr, string msg = "")
        {
            Console.WriteLine($"===============================\n{msg}");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");
       
        }
    }
}
