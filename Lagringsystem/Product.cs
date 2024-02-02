using System;
using System.Collections.Generic;
using System.Linq;

class Product : ProductType
{
    public string Name { get; set; }
    private decimal Price { get; set; }
    public int Stock { get; set; }

    public Product(string category, string name, decimal price, int stock)
            : base(category)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void ProductInfo()
    {
        ProductTypeInfo();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Stock: {Stock}");
    }

    public void RemoveFromStock(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) removed from stock.");
        }
        else
        {
            Console.WriteLine($"Error: Not enough {Name} in stock.");
        }
    }
    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;
        Console.WriteLine($"Price updated for {Name} to ${Price}");
    }

    
}