using System;
using System.Collections.Generic;
using System.Linq;
class ProductType
{
    private string Category { get; set; }

    public ProductType(string category)
    {
        Category = category;
    }

    public void ProductTypeInfo()
    {
        Console.WriteLine($"Category: {Category}");
    }
}