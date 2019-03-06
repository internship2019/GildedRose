using System;
namespace GildedRose.Console.InnItems
{
    public class ElixirOfTheMongoose : InnItemBase
    {
        public override string Name => "Elixir of the Mongoose";

        public ElixirOfTheMongoose(int sellIn = 5, int quality = 7) : base(sellIn, quality)
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
