using System;

namespace GildedRose.Inventory.Items
{
    public class ConjuredItem : BaseInnItem
    {
        private const string prefix = "Conjured";

        public ConjuredItem(string name, int sellIn, int quality) : base(AddPrefix(name, prefix), sellIn, quality)
        {
        }

        public override void Update()
        {
            base.Update();
            Quality--;
        }
    }
}
