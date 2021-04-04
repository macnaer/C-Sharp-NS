using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Interface_Exeptions
{
    abstract class Vehicle : IMove
    {
        public Vehicle(string brand = "Undefined", uint speed = 0)
        {
            Brand = brand;
            Speed = speed;
        }
        public string Brand { get; set; }
        public uint Speed { get; set; }

        abstract public void Move();
        public override string ToString()
        {
            return $"{this.GetType().Name} Brand: {Brand}  Speed: {Speed}";
        }
    }
}
