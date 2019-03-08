using System;
using System.Text.RegularExpressions;
using GildedRose.Inventory.Items;

namespace GildedRose.Inventory.ItemCategorization.Criterias
{
    public class IsConjuredCriteria : ICategorizationCriteria
    {
        public IInnItem TryCategorize(Item item)
        {
            if (Regex.IsMatch(item.Name, @"\bConjured \w+", RegexOptions.IgnoreCase))
                return new ConjuredItem(item.Name, item.SellIn, item.Quality);

            return null;
        }
    }
}
