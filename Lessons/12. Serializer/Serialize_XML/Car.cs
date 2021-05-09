﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_XML
{
    [Serializable]
    public class Engine
    {
        public double Power;
    }

    public class Car
    {
        [NonSerialized]
        private int Id;

        public string Brand { get; set; }

        public int Year { get; set; }

        public Engine Engine { get; set; } = new Engine();

        public override string ToString()
        {
            return $"{Id}\t{Brand}\t{Year}\t{Engine.Power}";
        }

        public Car() : this(0) { }

        public Car(int id = 0, string brand = "Unknown", int year = 2021, double power = 1.5)
        {
            this.Id = id;
            Brand = brand;
            Year = year;
            Engine.Power = power;
        }
    }
}