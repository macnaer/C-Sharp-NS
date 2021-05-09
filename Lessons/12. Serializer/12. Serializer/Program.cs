using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _12._Serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1, "Audi", 2014, 2.0);
            Console.WriteLine(car);

            BinaryFormatter bf = new BinaryFormatter();
            string fname = "Car.dat";

            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                bf.Serialize(fs, car);
                fs.Position = 0;
                Car readCar = (Car)bf.Deserialize(fs);
                Console.WriteLine($"Deserialize car: {readCar}");
            }

        }
    }
}
