using System;

class ShoppingCart
{
    private List<Product> cartItems = new List<Product>();

    public void AddToCart(Product product)
    {
        cartItems.Add(product);
    }

    public void DisplayCart()
    {
        Console.WriteLine("Shopping Cart:");
        foreach (var item in cartItems)
        {
            item.ShowInfo();
        }
    }
}
