using System;
namespace GildedRose.Console.InnItems
{
    public class ConjuredManaCake : InnItemBase
    {
        public override string Name => "Conjured Mana Cake";

        public ConjuredManaCake(int sellIn = 3, int quality = 6) : base(sellIn, quality)
        {
        }

        public override void Update()
        {
            if (Quality > 0)
                Quality -= 1;

            SellIn -= 1;

            if (SellIn < 0 && Quality > 0)
                Quality -= 1;
        }
    }
}
