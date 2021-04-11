using System;
using System.Collections.Generic;

namespace _07._Interface_exeptions_part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Example1 ICloneable
            //Student student = new() { Name = "Tom", Course = 2 };
            //student.Marks.AddRange(new int[] { 7, 11, 12, 6 });
            //Console.WriteLine(student);

            //Student clone = (Student)student.Clone();
            //Console.WriteLine($"Clone:=============== \n{clone}");
            //clone.Marks[0] = 10;
            //Console.WriteLine($"Clone:=============== \n{clone}");
            //Console.WriteLine($"Original:=============== \n{student}");

            // Example 2 IComparable
            CompareDemo();
        }

        private static void CompareDemo()
        {
            Student st1 = new() { Name = "Eva", Course = 2 };
            st1.Marks.AddRange(new int[] { 8, 9, 10, 10 });


            Student st2 = new() { Name = "Jenifer", Course = 4 };
            st2.Marks.AddRange(new int[] { 11, 12, 9, 8 });
            Student st3 = new() { Name = "Richerd", Course = 4 };
            st3.Marks.AddRange(new int[] { 11, 10, 9, 8 });

            Student st4 = new() { Name = "John", Course = 2 };
            st4.Marks.AddRange(new int[] { 7, 9, 10, 11 });

            Console.WriteLine($"st3 and st2 : {st3.CompareTo(st2)}"); // 1 якщо різні 0 якщо однакові
            Console.WriteLine($"st2 and st4 : {st2.CompareTo(st4)}"); // 1 якщо різні 0 якщо однакові

            List<Student> students = new List<Student>() { st2, st1, st4, st3 };
            students.Sort();
            Console.WriteLine("---------------------Sorted students--------");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------Sorted students by AVG marks--------");
            students.Sort(new CmpClasses());
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
