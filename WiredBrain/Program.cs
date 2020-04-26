using System;
using WiredBrain.DataAccess;

namespace WiredBrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee!");
            Console.WriteLine("Write 'help' to list available commands, " +
                "write 'quit' to exit");

            var coffeeShopDataProvider = new CoffeeShopDataProvider(); 

            while (true)
            {
                var line = Console.ReadLine();

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

                // Help command
                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }

                // Quit command
                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;                    
                }
            }
        }
    }
}
