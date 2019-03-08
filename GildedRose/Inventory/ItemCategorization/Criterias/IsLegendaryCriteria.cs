using System;
using System.Text.RegularExpressions;
using GildedRose.Inventory.Items;

namespace GildedRose.Inventory.ItemCategorization.Criterias
{
    public class IsLegendaryCriteria : ICategorizationCriteria
    {
        public IInnItem TryCategorize(Item item)
        {
            if (Regex.IsMatch(item.Name, @"\bSulfuras\b", RegexOptions.IgnoreCase))
                return new LegendaryItem(item.Name);

            return null;
        }
    }
}
