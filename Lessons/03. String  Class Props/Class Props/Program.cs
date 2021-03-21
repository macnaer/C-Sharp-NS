using System;

namespace Class_Props
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            // Example 1
            //Car car = new Car("Audi", 60, 200);

            // Example 2 
            Car car = new Car("Audi");
            Console.WriteLine($"Max speed = {car.MaxSpeed}");
            //Console.WriteLine(car.ToString());

            //car.Brend = "Mazda";
            //Console.WriteLine(car.ToString());

            car.CurrentSpeed = 300;
            //Console.WriteLine(car.ToString());

            // Example 3
            Console.WriteLine("================================================");
            Car car2 = new Car("Mazda", new DateTime(2017,9, 12), 50, 190);
            //Console.WriteLine(car2.ToString());

            // Example 4 DataTime
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine("=========================Garage=====================");
            Garage garage = new Garage();
            garage.AddCar(car2);
            garage.AddCar(car);
      
            Console.WriteLine(garage);

        }
        
    }
}
