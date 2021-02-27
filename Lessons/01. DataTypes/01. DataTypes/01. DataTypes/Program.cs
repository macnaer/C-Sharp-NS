using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name;
            //Console.WriteLine("Enter your name: ");
            //name = Console.ReadLine();
            //if (name == "")
            //{
            //    Console.WriteLine("Hello World!");
            //}
            //else
            //{
            //    Console.WriteLine("Hello, " + name + "!");
            //}

            int? nullInt = null;
            nullInt = nullInt ?? 50;
            Console.WriteLine("Result = {0} ",nullInt);
        }
    }
}
