using System;
namespace GildedRose.Console.InnItems
{
    public class AgedBrie : InnItemBase
    {
        public override string Name => "Aged Brie";

        public AgedBrie(int sellIn = 2, int quality = 0) : base(sellIn, quality)
        {
        }

        public override void Update()
        {
            if (Quality < 50)
                Quality += 1;

            SellIn -= 1;

            if (SellIn < 0 && Quality < 50)
                Quality += 1;
        }
    }
}
