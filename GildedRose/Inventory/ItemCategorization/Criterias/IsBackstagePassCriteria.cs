using System;
using System.Text.RegularExpressions;
using GildedRose.Inventory.Items;

namespace GildedRose.Inventory.ItemCategorization.Criterias
{
    public class IsBackstagePassCriteria : ICategorizationCriteria
    {
        public IInnItem TryCategorize(Item item)
        {
            if (Regex.IsMatch(item.Name, @"^Backstage Pass(es)?\b", RegexOptions.IgnoreCase))
                return new BackstagePassItem(item.Name, item.SellIn, item.Quality);

            return null;
        }
    }
}
