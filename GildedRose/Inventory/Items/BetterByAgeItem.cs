using System;

namespace GildedRose.Inventory.Items
{
    public class BetterByAgeItem : BaseInnItem
    {
        private const string prefix = "Aged";

        public BetterByAgeItem(string name, int sellIn, int quality) : base(AddPrefix(name, prefix), sellIn, quality)
        {
        }

        public override void Update()
        {
            SellIn--;
            Quality++;

            if (SellIn < 0)
                Quality++;
        }
    }
}
