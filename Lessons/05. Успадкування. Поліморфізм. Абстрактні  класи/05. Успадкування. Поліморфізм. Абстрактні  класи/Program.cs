using System;
using System.Collections.Generic;

namespace _05._Успадкування._Поліморфізм._Абстрактні__класи_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 
            //Person person = new Person() { Name = "Camilla Terry", Age = 30, Hobby = "Swimming" };
            //Console.WriteLine(person);

            // Example 2 
            Worker worker = new Worker(name: "Camilla Terry", age:30, hobby: "Swimming", salary: 3300);
            //Console.WriteLine(worker);
            Worker worker2 = new Worker(name: "Adam Smith", age: 20, hobby: "Gamming", salary: 3400);

            List<Person> persons = new List<Person>();
            persons.Add(worker);
            persons.Add(worker2);

            foreach (Person person in persons)
            {
                Console.WriteLine(person);
                person.Busy();
                person.PrintHobby();
                Console.WriteLine($"Pay: {person.Pay}");
            }

        }
    }
}
