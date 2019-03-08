using System;
using System.Collections.Generic;
using GildedRose.Inventory;
using GildedRose.Inventory.ItemCategorization;
using GildedRose.Inventory.ItemCategorization.Criterias;
using GildedRose.Inventory.Items;

namespace GildedRose
{
    public class GildedRoseInn
    {
        private readonly IInnInventory innInventory;

        public GildedRoseInn()
        {
            var categorizationCriterias = new ICategorizationCriteria[]
            {
                new IsBrieCheeseCriteria(),
                new IsBackstagePassCriteria(),
                new IsConjuredCriteria(),
                new IsLegendaryCriteria()
            };

            innInventory = new GildedRoseInventory(new ItemCategorizer(categorizationCriterias));
        }

        public void AddItem(Item item)
        {
            innInventory.Add(item);
        }

        public void UpdateQuality()
        {
            innInventory.UpdateQuality();
        }

        public IEnumerable<IInnItem> EnumerateItems()
        {
            return innInventory.EnumerateItems();
        }
    }
}
