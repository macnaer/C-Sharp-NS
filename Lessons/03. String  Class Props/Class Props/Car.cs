using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Props
{
    class Car  //  Неявно успадкувався від object
    {
        string brand;
        uint currentSpeed;
        public readonly uint MaxSpeed;
        // Example 1
        //public Car(string brand, uint currentSpeed = 0, uint maxSpeed = 200)
        //{
        //    MaxSpeed = maxSpeed;
        //    //this.brand = brand;
        //    this.Brend = brand;
        //    //this.currentSpeed = currentSpeed;
        //    this.CurrentSpeed = currentSpeed;
        //}

        //Example 2
        public Car(string brand, DateTime data = default, uint currentSpeed = 0, uint maxSpeed = 200)
        {
            MaxSpeed = maxSpeed;
            //this.brand = brand;
            this.Brend = brand;
            //this.currentSpeed = currentSpeed;
            this.CurrentSpeed = currentSpeed;
          
            if (data == default)
            {
                DateBuying = DateTime.Today;
            }
            else
            {
                DateBuying = data;
            }
        }

        public Car() : this("NoBrend") {}

        //public override string ToString()
        //{
        //    return $"Brend: {brand}\nCurrentSpeed: {currentSpeed}\nMax spped: {MaxSpeed}";
        //}


        // Стрілочний синтаксис
        // Example 1
        //public override string ToString() => $"Brend: {brand}\nCurrentSpeed: {currentSpeed}\nMax spped: {MaxSpeed}";

        // Example 2
        public override string ToString() => $"Brend: {brand}\nCurrentSpeed: {currentSpeed}\nMax spped: {MaxSpeed}\nDate: {DateBuying :dd.MM.yyyy}";

        public string Brend
        {
            get { return brand; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    brand = value;
                }
            }

        }

        public uint CurrentSpeed
        {
            get => currentSpeed;
            set => currentSpeed = value > MaxSpeed ? MaxSpeed : value;
        }

        // auto property компілятор сам генерує поле відповідного типу з дефолтним get; set;

        public DateTime DateBuying { get; set; }
    }
}
