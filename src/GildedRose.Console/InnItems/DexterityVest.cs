using System;
namespace GildedRose.Console.InnItems
{
    public class DexterityVest : InnItemBase
    {
        public override string Name => "+5 Dexterity Vest";

        public DexterityVest(int sellIn = 10, int quality = 20) : base(sellIn, quality)
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
