using System;
namespace GildedRose.Console.InnItems
{
    public class BackstagePassesToATafkal80etcConcert : InnItemBase
    {
        public override string Name => "Backstage passes to a TAFKAL80ETC concert";

        public BackstagePassesToATafkal80etcConcert(int sellIn = 15, int quality = 20) : base(sellIn, quality)
        {
        }

        public override void Update()
        {
            if (Quality < 50)
                Quality += 1;

            if (SellIn < 11 && Quality < 50)
                Quality += 1;

            if (SellIn < 6 && Quality < 50)
                Quality += 1;

            SellIn -= 1;

            if (SellIn < 0)
                Quality = 0;
        }
    }
}
