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

            //add breaks between lines and give a number to each option
            // List<Product> items = new List<Product>
            // {
            //     new Product(1, "The Dark Side Of The Moon - Pink Floyd", 50.00m , 5),
            //     new Product(2, "Sgt. Pepper's Lonely Hearts Club Band  - Beatles", 0.50m , 1),
            //     new Product(3, "Beggars Banquet  - Rolling Stones", 70.0m , 3),
            //     new Product(4, "Let's Dance - David Bowie", 80.00m , 2),
            //     new Product(5, "The Existential Soul - Tim Maia", 90.00m , 7)
            // };



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
                            {

                                foreach (Product item in items)
                                {
                                    item.ShowInfo();
                                }
                                break;
                            }
                        case 2:
                            {
                                //show my balance
                                user.ShowUserBalance();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("What would you like to purchase today?: ");

                                break;

                            }
                        case 4:
                            {
                                //view cart
                                Console.WriteLine("show my balance");
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


                // Check if user wants to do anything else after each chosen option
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

