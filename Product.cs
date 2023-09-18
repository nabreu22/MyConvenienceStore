using System;

class Product
{
    //attributes
    public string Name { get; }
    public float Price { get; }
    public int Stock { get; set; }

    //methods ---- posso usar diferentes metodos aqui e com diferentes funcoes, a depender se eu adiciono parametros ou nao, ver video 4 curso


    public Product(string name, float price, int stock)
    {
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