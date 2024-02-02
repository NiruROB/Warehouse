using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var product1 = new Product("", "Laptop", 799.99m, 10);
        var product2 = new Product("Clothing", "T-Shirt", 29.99m, 50);

        var warehouse = new Warehouse("Main Warehouse");
        warehouse.AddProduct(product1);
        warehouse.AddProduct(product2);

        Console.WriteLine("All Products and Their Stock:");
        warehouse.AllProducts();

        product2.RemoveFromStock(20);
        warehouse.AllProducts();
        
        product1.RemoveFromStock(15);
        warehouse.AllProducts();

        product1.UpdatePrice(899.99m);
        warehouse.AllProducts();

        Console.WriteLine("Random Product:");
        var randomProduct = warehouse.RandomProduct();
        if (randomProduct != null)
        {
            randomProduct.ProductInfo();
        }
    }
}