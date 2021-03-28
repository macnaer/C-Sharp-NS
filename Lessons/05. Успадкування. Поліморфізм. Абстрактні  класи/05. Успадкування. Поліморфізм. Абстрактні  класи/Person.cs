using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Успадкування._Поліморфізм._Абстрактні__класи_
{
    public abstract class Person
    {
        public Person(string name = "Annonymous", int age = 0, string hobby = "Unknown")
        {
            Name = name;
            Age = age;
            Hobby = hobby;
        }
        public string Name { get; set; }
        public int  Age { get; set; }
        public string Hobby { get; set; }

        public override string ToString()
        {
            return $"\n==================================\nName: {Name}\nAge: {Age}\nHobby: {Hobby}";
        }

        //public virtual uint Pay { get; }

        public abstract uint Pay { get; }

        //public virtual void Busy()
        //{
        //    Console.WriteLine($"{Name} is busy");

        //}

        public abstract void Busy();

        public void PrintHobby()
        {
            Console.WriteLine($"Class {this.GetType().Name} | {Name} has hobby {Hobby}");
        }
    }
}
