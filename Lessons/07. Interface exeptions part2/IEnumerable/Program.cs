using System;

namespace IEnumerable_example
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "IEnumerable";
            foreach (char item in str)
            {
                Console.WriteLine($"{item}");
            }

            var iter = str.GetEnumerator(); // Перелічувач який вказує на початок рядка
            while(iter.MoveNext())  // Робимо крок вперед і перевіряємо чи можна рухатись далі(чи є елемент)
            {
                Console.Write($"{iter.Current}\t");
            }

            Console.WriteLine("===================================");

            Student st1 = new() { Name = "Eva", Course = 2 };
            st1.Marks.AddRange(new int[] { 8, 9, 10, 10 });
            foreach (int mark in st1)
            {
                Console.WriteLine($"{mark}");
            }
        }
    }
}
