using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_example
{
    class Student : IEnumerable
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public double Avg => Marks.Average();


        public IEnumerator GetEnumerator()
        {
            return Marks.GetEnumerator(); // Використовуємо перелісувас який є у будь-якого List
        }

        public override string ToString()
        {
            //return $"Name: {Name}\nCourse: {Course}\nMarks : {String.Join(",", Marks)}";
            return $"Name: {Name}\nCourse: {Course}\nMarks : {String.Join(",", Marks)}\nAVG Marks : {Avg}";
        }
    }
}
