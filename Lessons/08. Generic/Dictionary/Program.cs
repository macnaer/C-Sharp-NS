using System;
using System.Collections.Generic;

namespace Dictionary_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cars = new Dictionary<string, string>()
            {
                ["Audi"] = "VK 0001 AV",
                ["Renault"] = "RT 1234 VA",
                ["BMW"] = "RV 3423 AM"
            };
            Console.WriteLine("==========================Dictionary======-===================");

            foreach (KeyValuePair<string, string> car in cars)
            {
                Console.WriteLine($"{car.Key}\t{car.Value}\n");
            }

            Console.WriteLine("==========================Sorted dictionary====================");

            SortedDictionary<string, string> carsSorted = new SortedDictionary<string, string>()
            {
                ["Audi"] = "VK 0001 AV",
                ["Renault"] = "RT 1234 VA",
                ["BMW"] = "RV 3423 AM"
            };

            foreach (KeyValuePair<string, string> car in carsSorted)
            {
                Console.WriteLine($"{car.Key}\t{car.Value}\n");
            }
        }
    }
}
