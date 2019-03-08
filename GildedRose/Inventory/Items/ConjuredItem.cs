using System;

namespace GildedRose.Inventory.Items
{
    public class ConjuredItem : BaseInnItem
    {
        public ConjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void Update()
        {
            base.Update();
            Quality--;
        }
    }
}
