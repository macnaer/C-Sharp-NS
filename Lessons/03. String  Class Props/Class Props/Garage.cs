using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Props
{
    class Garage
    {
        Car[] cars = new Car[0]; 
        public void AddCar(Car car) 
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (Car car in cars)
            {
                result += car.ToString() + "\n";
            }
            return result;

        }
    }
}
