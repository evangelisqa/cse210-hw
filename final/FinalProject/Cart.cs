using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

class Cart
{
    public List < Product > items = new List < Product >();

    public void AddToCart(Product product)
    {
        items.Add ( product );
        Console.WriteLine($"{product.Name} added to cart.");
    }
    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.Price;
        }
        return total;
    }
}