using System;

namespace Delegate_generic
{
    delegate T AddDelegat<T>(T a, T b);  // generic delagate
    class Program
    {
        static void Main(string[] args)
        {
            AddDelegat<double> d1 = AddCalc.AddNumbers;
            Console.WriteLine($"d1 => {d1(1.3, 2.1)}");

            AddDelegat<string> d2 = AddCalc.ContactString;
            Console.WriteLine($"d2 => {d2("Hello ", "world")}");

            AddDelegat<TimeSpan> d3 = AddCalc.AddTimeSpan;
            Console.WriteLine($"d3 => {d3(TimeSpan.FromMinutes(2), TimeSpan.FromMinutes(4))}");
        }
    }

    class AddCalc
    {
        public static double AddNumbers(double a, double b) => a + b;
        public static string ContactString(string a, string b) => a + b;
        public static TimeSpan AddTimeSpan(TimeSpan a, TimeSpan b) => a + b;

    }
}
