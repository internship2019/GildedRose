using System;
using System.Collections.Generic;
using GildedRose.Inventory.ItemCategorization;
using GildedRose.Inventory.Items;

namespace GildedRose.Inventory
{
    public class GildedRoseInventory : IInnInventory
    {
        private readonly IItemCategorizer itemCategorizer;
        private ICollection<IInnItem> items;

        public GildedRoseInventory(IItemCategorizer itemCategorizer)
        {
            this.itemCategorizer = itemCategorizer;
            this.items = new List<IInnItem>();
        }

        public void Add(Item newItem)
        {
            items.Add(itemCategorizer.Categorize(newItem));
        }

        public void UpdateQuality()
        {
            foreach (var item in items)
                item.Update();
        }

        public IEnumerable<IInnItem> EnumerateItems()
        {
            return items;
        }
    }
}
