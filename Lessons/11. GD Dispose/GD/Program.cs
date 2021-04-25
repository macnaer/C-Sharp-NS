using System;

namespace GC
{
    class Demo
    {
        static int lastId = 0;
        public readonly int ID = ++lastId;
        int[] buffer;
        const int SIZE = 10;

        public Demo()
        {
            buffer = new int[SIZE];
            Console.WriteLine($"Created : {ID}");
        }

        ~Demo() // фіналізатор - звільняє некеровані ресурси (файлові дескриптори, мережеві з'эднання, пыдключення до бази )
        {
            Console.WriteLine($"=============Finalize============={ID}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int times = 1_00_00;
            Demo d1 = new Demo();
            for(int i = 0; i < times; i++)
            {
                d1 = new Demo();
            }
            Console.WriteLine($"d1 => {d1.ID}");
            
            Console.WriteLine("===========END===============");
        }
    }
}
