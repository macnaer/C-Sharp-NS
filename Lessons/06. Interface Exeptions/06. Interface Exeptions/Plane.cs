using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Interface_Exeptions
{
    class Plane : Vehicle, IFlay
    {
        uint height;
        public uint Height { get => height; set => height = value <= IFlay.MaxHeight ? value : IFlay.MaxHeight; }

        public Plane(string brand = "No name", uint speed = 500, uint height = 6000):base(brand, speed)
        {
            Height = height;
        }

        public override void Move()
        {
            Console.WriteLine($"Plane: {Brand} is flying with speed {Speed} and height {Height}");
        }
    }
}
