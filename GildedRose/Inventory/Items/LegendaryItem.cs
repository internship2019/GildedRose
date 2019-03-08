using System;

namespace GildedRose.Inventory.Items
{
    public class LegendaryItem : BaseInnItem
    {
        private const int maxLegendaryQuality = 80;

        protected override int MaxQuality => maxLegendaryQuality;

        public LegendaryItem(string name) : base(name, 0, maxLegendaryQuality)
        {
        }

        public override void Update()
        {
            // Do nothing
        }

        public override string ToString()
        {
            return base.ToString() + " A Legendary item";
        }
    }
}
