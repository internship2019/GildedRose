using System;

namespace GildedRose.Inventory.Items
{
    public class BackstagePassItem : BaseInnItem
    {
        private const string prefix = "Backstage Passes";

        public BackstagePassItem(string name, int sellIn, int quality) : base(AddPrefix(name, prefix), sellIn, quality)
        {
        }

        public override void Update()
        {

            if (SellIn <= 0)
                Quality = 0;
            else
            {
                Quality++;

                if (SellIn <= 5)
                    Quality += 1;

                if (SellIn <= 10)
                    Quality += 1;
            }
            SellIn--;
        }
    }
}
