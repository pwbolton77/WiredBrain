﻿using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrain.DataAccess.Model;

namespace WiredBrain
{
    internal class CoffeeShopCommandHandler : ICommandHandler
    {
        private IEnumerable<CoffeeShop> coffeeShops;
        private string line;

        public CoffeeShopCommandHandler(IEnumerable<CoffeeShop> coffeeShops, string line)
        {
            this.coffeeShops = coffeeShops;
            this.line = line;
        }

        public void handleCommand()
        {
            var foundCoffeeShops = coffeeShops
                .Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (foundCoffeeShops.Count == 0)
            {
                Console.WriteLine($"> Command '{line}' not found");
            }
            else if (foundCoffeeShops.Count == 1)
            {
                var coffeeShop = foundCoffeeShops.Single();
                Console.WriteLine($"> Location: {coffeeShop.Location}");
                Console.WriteLine($"> Beans in stock: {coffeeShop.BeansInStockInKg} kg");
            }
            else
            {
                Console.WriteLine($">Multiple matching coffee shop commands found: ");
                foreach (var coffeeType in foundCoffeeShops)
                {
                    Console.WriteLine($">    {coffeeType.Location}");
                }
            }
        }
    }
}