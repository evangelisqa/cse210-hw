using System;
using System.Collections.Generic;

class Order
{
    public List < Product > OrderedItems { get; set; } = new List<Product> ();
    public decimal TotalPrice { get; set; }
}