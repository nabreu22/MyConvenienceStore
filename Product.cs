using System;
using System.Data.Common;

class Product
{
    //attributes

    public int Id { get; set; }
    public string Name { get; }
    public decimal Price { get; }
    public int Stock { get; set; }

    //methods 


    public Product(int id, string name, decimal price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }

    //show info
    public void ShowInfo()
    {
        Console.WriteLine($"{Id} - {Name} - {Price}");
    }

    //check stock and show info
    public void CheckStock(int Stock)
    {
        string stockStatus = (Stock <= 0) ? "Item Sold Out" : "XXX";
    }
}