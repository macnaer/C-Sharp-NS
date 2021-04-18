using System;
using System.Linq;

namespace Delegae_as_param
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 6, 3, 4, 32, -12, 2 };
            Console.WriteLine($"Count > 0 {arr.Count( x => x > 0)}");
        }
    }
}
