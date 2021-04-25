using System;

namespace _10._Events
{

    delegate void MyDelegate(string msg);
    class Car
    {
        public readonly uint MaxSpeed;

        public string Brand { get; set; }

        public event MyDelegate ToHoghtSpeed;

        uint speed;

        public Car(string brand = "Unknown", uint maxSpeed = 60)
        {
            this.Brand = brand;
            this.MaxSpeed = maxSpeed;
        }
       

        public uint Speed
        {
            get => speed;
            set
            {
                speed = value;
                if(value >= MaxSpeed)
                {
                    if(speed > MaxSpeed)
                        speed = MaxSpeed;
                    ToHoghtSpeed?.Invoke($"{Brand} To high speed! Max speed  {MaxSpeed} | your speed {speed}");
                }
            }
        }
        public override string ToString()
        {
            return $"Brand: {Brand}\t Speed: {Speed}";
        }

    }

    class Patrol
    {
        public string Name { get; set; }
        public void CatchViolation(string msg)
        {
            Console.WriteLine($"Patrol {Name} catch violation\n{msg}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Audi", 90);

            Patrol patrol1 = new Patrol() { Name = "Rivne 01" };
            Patrol patrol2 = new Patrol() { Name = "Lviv 21" };

            car.ToHoghtSpeed += patrol1.CatchViolation;  // Subscribe
            car.ToHoghtSpeed += patrol2.CatchViolation;
            car.Speed = 130;
            Console.WriteLine($"{car.Brand} : Speed {car.Speed}");
        }
    }
}
