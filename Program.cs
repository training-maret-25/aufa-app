using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Transactions;
using System.Xml.Linq;

public class MyClass
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product { Name = "Smartphone", Price = 5000000 },
            new Product { Name = "Laptop", Price = 12000000 },
            new Product { Name = "Headphone", Price = 1500000 },
            new Product { Name = "Monitor", Price = 3000000 }
        };

        var highest = products.OrderByDescending(e => e.Price).Take(1);

        foreach (var highesProduct in highest)
        {
            Console.WriteLine($"produk {highesProduct.Name} dengan harga {highesProduct.Price}");
        }
    }
}