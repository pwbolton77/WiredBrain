using System.Collections.Generic;
using WiredBrain.DataAccess.Model;

namespace WiredBrain.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 107, PaperCupsInStock = 20 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStockInKg = 23, PaperCupsInStock = 30 };
            yield return new CoffeeShop { Location = "Munich", BeansInStockInKg = 56, PaperCupsInStock = 40 };
        }
    }
}
