using System;

namespace GildedRose.Inventory.Items
{
    public interface IInnItem
    {
        string Name { get; }
        int SellIn { get; }
        int Quality { get; }

        void Update();
    }
}
