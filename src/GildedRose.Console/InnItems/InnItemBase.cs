using System;
namespace GildedRose.Console.InnItems
{
    public abstract class InnItemBase : IInnItem
    {
        public abstract string Name { get; }
        public int SellIn { get; protected set; }
        public int Quality { get; protected set; }

        protected InnItemBase(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public abstract void Update();
    }
}
