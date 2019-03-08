using System;

namespace GildedRose.Inventory.Items
{
    public class BetterByAgeItem : BaseInnItem
    {
        public BetterByAgeItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void Update()
        {
            SellIn--;
            Quality++;

            if (SellIn < 0)
                Quality++;
        }

        public override string ToString()
        {
            return base.ToString() + " It gets better by age.";
        }
    }
}
