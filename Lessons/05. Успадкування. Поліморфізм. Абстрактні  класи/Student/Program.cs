using _05._Успадкування._Поліморфізм._Абстрактні__класи_;
using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker2 = new Worker("Bill", 34, "Programming", 3500);
            Console.WriteLine($"worker2 => {worker2}");
        }
    }
}
