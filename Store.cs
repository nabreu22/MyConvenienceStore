using System;
class Store
{
    private List<Product> products = new List<Product>();

    public Store()
    {
        products.Add(new Product(1, "The Dark Side Of The Moon - Pink Floyd", 50.00m, 5));
        products.Add(new Product(2, "Sgt. Pepper's Lonely Hearts Club Band - Beatles", 0.50m, 1));
        products.Add(new Product(3, "Beggars Banquet - Rolling Stones", 70.0m, 3));
        products.Add(new Product(4, "Let's Dance - David Bowie", 80.00m, 2));
        products.Add(new Product(5, "The Existential Soul - Tim Maia", 90.00m, 1));
    }

    public void ListAvailableProducts()
    {
        Console.WriteLine("Available Products:");
        foreach (var product in products)
        {
            if (product.Stock > 0)
            {
                product.ShowInfo();
            }
        }
    }

    public Product GetProductByNumber(int productNumber)
    {
        return products.Find(p => p.Id == productNumber);
    }

    public bool AddProductToCart(ShoppingCart cart, int productNumber, User user)
    {
        Product product = GetProductByNumber(productNumber);
        if (product != null && product.Stock > 0)
        {
            decimal totalPrice = product.Price;
            if (user.DeductFromBalance(totalPrice))
            {
                cart.AddToCart(product);
                product.Stock--;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance to make the purchase.");
            }
        }
        else
        {
            Console.WriteLine("Product is out of stock.");
        }
        return false;

    }




}


