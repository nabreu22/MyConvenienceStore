using System;
using System.Data.Common;

class Product
{
    //attributes

    public int Id { get; set; }
    public string Name { get; }
    public decimal Price { get; }
    public int Stock { get; set; }

    //methods ---- posso usar diferentes metodos aqui e com diferentes funcoes, a depender se eu adiciono parametros ou nao, ver video 4 curso


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
        Console.WriteLine($"{Name} - {Price}");
    }

    //check stock and show info
    public void CheckStock(int Stock)
    {
        string stockStatus = (Stock <= 0) ? "Item Sold Out" : "XXX";
    }
}