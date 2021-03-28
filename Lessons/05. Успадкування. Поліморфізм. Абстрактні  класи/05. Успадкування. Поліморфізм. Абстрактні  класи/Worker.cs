using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Успадкування._Поліморфізм._Абстрактні__класи_
{

    // internal видно з у межах проекту (збірки) 
    // public видно у інших проектах
    // sealed - Не можно успадковуватись можна використовувати до virtual

    public sealed class Worker : Person
    {
        public uint salary;
        const uint MinSalary = 3200;
        public uint Salary { 
            get => salary; 
            set
            {
                if (value >= MinSalary)
                {
                    salary = value;
                }
                else
                {
                    salary = MinSalary;
                }
            }
        }
        public Worker(string name = "Annonymous", int age = 18, string hobby = "Unknown", uint salary = MinSalary) : base(name, age, hobby)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSalary: {Salary}";
        }

        public override void Busy()
        {
            Console.WriteLine($"Worker {Name} is working!");
        }

        public override uint Pay => salary;

        public new void PrintHobby()
        {
            Console.WriteLine($"Worker {Name} has hobby {Hobby}");
        }

    }
}
