using System.Collections.Generic;
using GildedRose.Console.InnItems;

namespace GildedRose.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var inn = new GildedInn(InitializeItems());
            inn.UpdateQuality();

            System.Console.ReadKey();
        }

        private static IList<IInnItem> InitializeItems()
        {
            return new List<IInnItem>
            {
                new DexterityVest(),
                new AgedBrie(),
                new ElixirOfTheMongoose(),
                new SulfurasHandOfRagnaros(),
                new BackstagePassesToATafkal80etcConcert(),
                new ConjuredManaCake()
            };
        }
    }
}
