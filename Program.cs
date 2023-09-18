using System;

namespace ConvenienceStore
{
    public class Program
    {
        static void Main(string[] args)

        {

            List<Product> items = new List<Product>
            {
                new Product("The Dark Side Of The Moon - Pink Floyd", 50.00f, 5),
                new Product("The  - Beatles", 0.50f , 1),
                new Product("The  - Rolling Stones", 70.0f, 3),
                new Product("The  - David Bowie", 80.00f, 2),
                new Product("The  - Tim Maia", 90.00f, 7)
            };



            while (true)
            {
                Console.WriteLine("Welcome to MyRecordStore - Please, choose what you want to do next: ");
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
                                Console.WriteLine("show my balance");
                                // break;
                                return;
                            }
                        case 3:
                            {
                                //purchase 
                                Console.WriteLine("purchase ");
                                // break;
                                return;
                            }
                        case 4:
                            {
                                //view cart
                                Console.WriteLine("show my balance");
                                // break;
                                return;
                            }
                        case 5:
                            {
                                Console.WriteLine("break");
                                // break;
                                return;
                            }
                    }

                }
                else
                {

                }
                break;
            }

        }
    }
}

