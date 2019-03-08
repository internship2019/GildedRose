using System;
using System.Collections.Generic;
using GildedRose.Inventory.ItemCategorization.Criterias;
using GildedRose.Inventory.Items;

namespace GildedRose.Inventory.ItemCategorization
{
    public class ItemCategorizer : IItemCategorizer
    {
        private readonly IList<ICategorizationCriteria> criterias;

        public ItemCategorizer(IList<ICategorizationCriteria> criterias)
        {
            this.criterias = criterias;
        }

        public IInnItem Categorize(Item item)
        {
            IInnItem resultItem = null;
            foreach (var criteria in criterias)
            {
                resultItem = criteria.TryCategorize(item);
                if (resultItem != null)
                    return resultItem;
            }

            return CateogrizeAsDefault(item);
        }

        private IInnItem CateogrizeAsDefault(Item item)
        {
            return new BasicInnItem(item.Name, item.SellIn, item.Quality);
        }
    }
}
