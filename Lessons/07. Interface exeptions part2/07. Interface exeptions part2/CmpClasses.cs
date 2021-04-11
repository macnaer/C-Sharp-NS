using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Interface_exeptions_part2
{
    class CmpClasses : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if(ReferenceEquals(x, y))
            {
                return 0;
            }
            if (x is null)
            {
                return -1;
            }
            if (y is null)
            {
                return 1;
            }
            return -x.Avg.CompareTo(y.Avg); // По спаданню
        }
    }
}
