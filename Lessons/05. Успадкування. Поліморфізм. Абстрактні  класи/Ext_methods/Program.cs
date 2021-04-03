using System;

namespace Ext_methods
{
    // extention methods 
    // 1. in static class
    // 

    static class IntExtention
    {
        public static int CountDigits(this int number)
        {
            return Math.Abs(number).ToString().Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntExtention.CountDigits(123));
            int value = -3456;
            Console.WriteLine(value.CountDigits());
        }
    }
}
