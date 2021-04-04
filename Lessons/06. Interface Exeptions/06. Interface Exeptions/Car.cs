using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Interface_Exeptions
{
    class Car : Vehicle
    {
        public Car(string brand = "No name", uint speed = 50) : base(brand, speed) { }
 
        public override void Move()
        {
            Console.WriteLine($"Car {Brand} is moving by road with speed {Speed}");
        }
    }
}
