using System;
using System.Collections.Generic;
using WiredBrain.DataAccess.Model;

namespace WiredBrain
{
    internal class HelpCommandHandler : ICommandHandler
    {
        private IEnumerable<CoffeeShop> coffeeShops;

        public HelpCommandHandler(IEnumerable<CoffeeShop> coffeeShops)
        {
            this.coffeeShops = coffeeShops;
        }

        public void handleCommand()
        {
            Console.WriteLine("> Available coffee shop commands:");
            foreach (var coffeeShop in coffeeShops)
            {
                Console.WriteLine($"> {coffeeShop.Location}");
            }
        }
    }
}