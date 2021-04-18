using System;
using System.Collections.Generic;

namespace _09._Delegate
{
    delegate void MyDelegate(string str);
    class Program
    {   // delegate = це ти(клас)  який інкапсулює у собі мктод з певною сігнатурою

        static void Hello(string name)    // Співпадає з делегатом
        {
            Console.WriteLine($"Hello, {name}");
        }

        static void Bye(string name)
        {
            Console.WriteLine($"Bye, {name}");
        }

        static void Main(string[] args)
        {
            MyDelegate deleg = new MyDelegate(Program.Hello); 
            Hello("Bill");  // Спрощений виклик методу який посилається на делегат
            Console.WriteLine($"Delegate =====>> {deleg.Method}");
            Console.WriteLine($"Target =====>> {deleg.Target}");
            deleg("Eva");
            deleg = Program.Bye;
            deleg("Eva");
            deleg.Invoke("Ted"); // Виклик методу який посилається на делегат
            deleg = (string msg) => Console.WriteLine($"See you {msg}.");
            deleg("Eva");
            Console.WriteLine($"Delegate =====>> {deleg.Method}");

            Person jack = new Person() { Name = "Jack", Age = 43 };
            Person camilla = new Person() { Name = "Camilla", Age = 32 };

            deleg = jack.Busy;
    
            Console.WriteLine($"Delegate =====>> {deleg.Method}");
            Console.WriteLine($"Target =====>> {deleg.Target}");
            deleg?.Invoke("hometask in c#");
            jack.PrintThings();

            deleg = Hello;
            deleg += Hello;
            deleg += Bye;

            deleg("Robert");

            deleg -= Hello;
            deleg("Robert");

            Console.WriteLine("=================================");

            foreach (var item in deleg.GetInvocationList())   // По групі методів які прив'язані до делегату
            {
                Console.WriteLine($"Current method => {item.Method}\t");
                Console.WriteLine($"{item.DynamicInvoke("Stiven")}");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<string> Things { get; set; } = new List<string>();

        public void Busy(string things)
        {
            Console.WriteLine($"Person {Name} with age {Age} is doing {things}");
            Things.Add(things);
        }

        public void PrintThings()
        {
            Console.WriteLine($"{Name} things : {String.Join(",", Things )}");
        }
    }
}
