using System;

namespace Delegate_result
{
    delegate double CalcDelegate(double a, double b);

    class Calc
    {
        public static double Add(double a, double b) => a + b;
        public static double Mult(double a, double b) => a * b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            CalcDelegate calculator = Calc.Add;
            Console.WriteLine($"{calculator.Method.Name} : {calculator?.Invoke(2, 4)}");
            calculator += Calc.Mult;
            Console.WriteLine($"{calculator.Method.Name} : {calculator?.Invoke(2, 4)}");
            Console.WriteLine("========================");
            foreach(Delegate deleg in calculator.GetInvocationList())
            {
                Console.WriteLine($"{deleg.Method.Name} : {deleg.DynamicInvoke(5,5)}");
            }
        }
    }
}
