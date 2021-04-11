using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Interface_exeptions_part2
{
    class Student : ICloneable, IComparable, IComparable<Student>
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public double Avg => Marks.Average();

        public object Clone()
        {
            Student st = new Student() { Name = this.Name, Course = this.Course };
            st.Marks.AddRange(this.Marks);
            return st;
        }

        public int CompareTo(object obj)
        {
            Student st = obj as Student;
            if (st is null)
            {
                throw new FormatException("Error type object. Object not a student");
            }
            if (this.Course != st.Course)
            {
                return this.Course.CompareTo(st.Course);  // Повертає 1 або -1;
            }
            return this.Name.CompareTo(st.Name); // // Повертає 0, 1 або -1;
        }

        public int CompareTo(Student other)
        {
            if (other is null)
            {
                return 1;
            }
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            //return $"Name: {Name}\nCourse: {Course}\nMarks : {String.Join(",", Marks)}";
            return $"Name: {Name}\nCourse: {Course}\nMarks : {String.Join(",", Marks)}\nAVG Marks : {Avg}";
        }
    }
}
