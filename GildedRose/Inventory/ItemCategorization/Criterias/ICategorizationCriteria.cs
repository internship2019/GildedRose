using System;
using GildedRose.Inventory.Items;

namespace GildedRose.Inventory.ItemCategorization.Criterias
{
    public interface ICategorizationCriteria
    {
        IInnItem TryCategorize(Item item);
    }
}
