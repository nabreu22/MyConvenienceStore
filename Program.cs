using System;

namespace ConvenienceStore
{
    public class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hi, before to proceed, please inform your first name: ");
            string userFirstName = Console.ReadLine();

            Console.WriteLine($"Hello {userFirstName} welcome to MyRecordStore - Please, choose what you want to do next: ");

            User user = new User(userFirstName, 200.0m);

            Store convenienceStore = new Store();
            ShoppingCart cart = new ShoppingCart();


            while (true)
            {

                Console.WriteLine("1 - List Products");
                Console.WriteLine("2 - Show my balance");
                Console.WriteLine("3 - Purchase");
                Console.WriteLine("4 - View Cart");
                Console.WriteLine("5 - Exit");

                int answer;

                if (int.TryParse(Console.ReadLine(), out answer) && answer >= 1 && answer <= 5)
                {
                    switch (answer)
                    {
                        case 1:
                            //list products
                            {
                                convenienceStore.ListAvailableProducts();
                                break;
                            }
                        case 2:
                            //show my balance
                            {
                                user.ShowUserBalance();
                                break;
                            }
                        case 3:
                            //purchase
                            {
                                Console.WriteLine("What would you like to purchase today?(give me the number ): ");
                                if (int.TryParse(Console.ReadLine(), out int productNumber))
                                {
                                    convenienceStore.AddProductToCart(cart, productNumber, user);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid product number entered.");
                                }
                                break;
                            }
                        case 4:
                            //view cart
                            {
                                //view cart
                                cart.DisplayCart();
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Exiting...");
                                return;
                            }
                    }

                }
                else
                {
                    Console.WriteLine("It will work but only if you pic a number between 1 to 5");

                }


                // Check if user wants to do anything else 
                Console.WriteLine("Do you want to continue? (yes/y or no/n)");
                string continueResponse = Console.ReadLine().ToLower();

                while (true)
                {
                    if (continueResponse == "yes" || continueResponse == "y")
                    {
                        break;
                    }
                    else if (continueResponse == "no" || continueResponse == "n")
                    {
                        Console.WriteLine("Exiting...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please, inform a valid answer: yes(y) or no(n)");
                        continueResponse = Console.ReadLine().ToLower();
                    }
                }


            }

        }
    }
}

