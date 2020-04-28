using System;
using System.Linq;
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

                // Quit command
                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var commandHandler = string.Equals("help", line, StringComparison.OrdinalIgnoreCase) ? 
                    new HelpCommandHandler(coffeeShops) as ICommandHandler :
                    new CoffeeShopCommandHandler(coffeeShops, line);

                commandHandler.handleCommand();
            }
        }
    }
}
