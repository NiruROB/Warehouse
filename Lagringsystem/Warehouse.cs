using System;
using System.Collections.Generic;
using System.Linq;

class Warehouse
{
    private string WarehouseName { get; set; }
    private List<Product> Products { get; } = new List<Product>();

    public Warehouse(string warehouseName)
    {
        WarehouseName = warehouseName;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void AllProducts()
    {
        Console.WriteLine($"Warehouse: {WarehouseName}");
        Console.WriteLine("All Products in Stock:");
        foreach (var product in Products)
        {
            product.ProductInfo();
            Console.WriteLine();
        }
    }

    public Product RandomProduct()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("Error: No more product stock.");
            return null;
        }

        Random random = new Random();
        int randomIndex = random.Next(Products.Count);
        return Products[randomIndex];
    }
}
