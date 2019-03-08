using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GildedRose.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var inn = new GildedRoseInn();
            AddItems(inn);

            System.Console.ReadKey();
        }

        private static void AddItems(GildedRoseInn inn)
        {
            inn.AddItem(new Item("+5 Dexterity Vest", 10, 20));
            inn.AddItem(new Item("Aged Brie", 2, 0));
            inn.AddItem(new Item("Elixir of the Mongoose", 5, 7));
            inn.AddItem(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
            inn.AddItem(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
            inn.AddItem(new Item("Conjured Mana Cake", 3, 6));
        }
    }
}
