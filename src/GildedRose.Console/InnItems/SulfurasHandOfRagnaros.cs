using System;
namespace GildedRose.Console.InnItems
{
    public class SulfurasHandOfRagnaros : InnItemBase
    {
        public override string Name => "Sulfuras, Hand of Ragnaros";

        public SulfurasHandOfRagnaros(int sellIn = 0, int quality = 80) : base(sellIn, quality)
        {
        }

        public override void Update()
        {
            // Do nothing.
        }
    }
}
