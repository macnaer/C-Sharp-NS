using System;

namespace Interface_conflict
{
    class Program
    {
        static void Main(string[] args)
        {
            Squere squere = new() { Side = 30 }; // .NET 5
            squere.SetColor(ConsoleColor.Red);
            //squere.Print();

            IFile ifl = squere;
            ifl.Print();

            (squere as IConsole).Print();
        }
    }
}
