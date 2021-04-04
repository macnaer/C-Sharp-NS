using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_conflict
{
    interface IFile
    {
        void Print();
    }
    interface IConsole
    {
        void SetColor(ConsoleColor color);
        void Print();
    }
}
