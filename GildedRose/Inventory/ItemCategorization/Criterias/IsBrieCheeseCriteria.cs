using System;
using System.Text.RegularExpressions;
using GildedRose.Inventory.Items;

namespace GildedRose.Inventory.ItemCategorization.Criterias
{
    public class IsBrieCheeseCriteria : ICategorizationCriteria
    {
        public IInnItem TryCategorize(Item item)
        {
            if (Regex.IsMatch(item.Name, @"\bbrie\b", RegexOptions.IgnoreCase))
                return new BetterByAgeItem(item.Name, item.SellIn, item.Quality);

            return null;
        }
    }
}
