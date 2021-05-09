using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Serialize_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1, "BMW", 2014, 2.5);
            Car car2 = new Car(2, "Audi", 2013, 2.2);

            List<Car> cars = new List<Car> { car, car2 };
            XmlSerializer xs = new XmlSerializer(typeof(List<Car>));

            string fname = "../../Cars.xml";

            using (StreamWriter sw = new StreamWriter(fname))
            {
                xs.Serialize(sw, cars);
            }

            using (StreamReader sr = new StreamReader(fname))
            {
                List<Car> readCars = (List<Car>)xs.Deserialize(sr);
                Console.WriteLine($"Read cars: {String.Join("\n", readCars)}");
            }
        }
    }
}
