using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_conflict
{
    class Squere : IFile, IConsole
    {
        public uint Side { get; set; } = 15;

        //public void Print() // неявна реалізація
        //{
        //    Console.WriteLine($"Squere with side {Side}");
        //    Console.ResetColor();
        //}
        void IConsole.Print()
        {
            Console.WriteLine($"IConsole.Print()");
        }
        void IFile.Print()
        {
            Console.WriteLine($"IFile.Print()");
        }

        public void SetColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
    }
}
