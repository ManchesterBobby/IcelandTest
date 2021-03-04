using System;

namespace IcelandTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            var updates = inventory.UpdateInventory();

            foreach (var product in updates)
            {
                Console.WriteLine($"{product.ProductName} {product.SellIn} {product.QualityRating}");
            }
        }
    }
}
