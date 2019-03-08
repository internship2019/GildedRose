using System;
using System.Collections.Generic;
using GildedRose.Inventory.Items;

namespace GildedRose.Inventory
{
    public interface IInnInventory
    {
        void Add(Item item);
        void UpdateQuality();
        IEnumerable<IInnItem> EnumerateItems();
    }
}
