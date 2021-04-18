using System;
using System.Collections;

namespace SortedList_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ключі мають бути унікальними
            SortedList sl = new SortedList() // Object key => object value (ключі повинні бути одного типу)
            {
                { 1, "Monitor" },
                { 2, "Laptop"},
                { 3, "CPU"}
            };

            sl.Add(22, "Book");

            foreach(var item in sl.Keys)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine("\n");

            foreach (var item in sl.Values)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine("\n\n");
            foreach (DictionaryEntry item in sl)
            {
                Console.Write($"{item.Key}\t {item.Value}\n");
            }
        }
    }
}
