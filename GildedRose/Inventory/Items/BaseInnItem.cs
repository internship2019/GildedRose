using System;

namespace GildedRose.Inventory.Items
{
    public abstract class BaseInnItem : IInnItem
    {
        protected virtual int MaxQuality { get; } = 50;

        public string Name { get; private set; }

        public int SellIn { get; set; }

        private int quality;
        public int Quality
        {
            get { return quality; }
            protected set
            {
                quality = Math.Max(Math.Min(value, MaxQuality), 0);
            }
        }

        protected BaseInnItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public virtual void Update()
        {
            Quality--;
            SellIn--;

            if (SellIn < 0)
                Quality--;
        }

        public override string ToString()
        {
            return $"{Name}: SellIn {SellIn}. Quality = {Quality}.";
        }
    }
}
