using System;

namespace _11._GD_Dispose
{

    class Product
    {
        public event Action<string> PriceChanged;
        public string Name { get; set; }
        double price;

        public double Price
        {
            get => price;
            set
            {
                if (value != price)
                {
                    PriceChanged?.Invoke("Price changed!");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product { Name = "milk", Price = 23.5 };
            product.PriceChanged += (string m) => Console.WriteLine(m);
            product.Price = 24;
        }
    }
}
