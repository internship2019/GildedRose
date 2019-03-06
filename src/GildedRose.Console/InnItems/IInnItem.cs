using System;

namespace GildedRose.Console.InnItems
{
    public interface IInnItem
    {
        string Name { get; }
        int SellIn { get; }
        int Quality { get; }

        void Update();
    }
}
