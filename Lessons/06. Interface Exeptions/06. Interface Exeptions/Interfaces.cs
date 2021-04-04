using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Interface_Exeptions
{
    interface IMove
    {
        // методи властивості властивості, статичні поля, константи, статичні методи 
        void Move();  // Елементи інтерфейсу неявно public і неявно abstract (без реалізації)
        uint Speed { get; set; } // Неявно абстрактна властивість
    }

    interface IFlay : IMove
    {
        uint Height { get; set; }
        const uint MaxHeight = 11000;
    }
}
