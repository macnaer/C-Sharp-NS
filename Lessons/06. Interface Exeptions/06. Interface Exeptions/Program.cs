using System;
using System.Collections.Generic;

namespace _06._Interface_Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Audi", 100);
            Console.WriteLine(car);
            car.Move();
            //===================
            IMove im = car; // Інтерфейсне посилання --> буде видно тільки те що стосується IMove
            im.Move();

            Plane plane = new Plane("Boeng", 700, 10200);
            im = plane;
            im.Move();

            IFlay fl = plane;
            Console.WriteLine($"Height => {fl.Height}");

            List<IMove> moveable = new List<IMove>
            {
                car, plane
            };

            Console.WriteLine("\n\n_____________________Moveable objects____________________");
            foreach (var item in moveable)
            {
            
                Console.WriteLine(item);
                item.Move();
                if (item is IFlay)
                {
                    //Console.WriteLine($"Height flying on height {((IFlay)item).Height}");
                    Console.WriteLine($"Height flying on height {(item as IFlay).Height}");
                }
                Console.WriteLine("________________________________________________________");
            }

        }
    }
}
