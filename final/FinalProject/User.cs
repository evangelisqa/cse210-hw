using System;
using System.Collections.Generic;

class User 
{
    internal static string username;

    public string Username {get; set;}
    public List<Order> Orders { get; set;} = new List<Order>();
}