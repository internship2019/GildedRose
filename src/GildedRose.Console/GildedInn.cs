using System;
using System.Collections.Generic;
using GildedRose.Console.InnItems;

namespace GildedRose.Console
{
    public class GildedInn
    {
        private readonly IList<IInnItem> items;

        public GildedInn(IList<IInnItem> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in items)
                item.Update();
        }
    }
}
