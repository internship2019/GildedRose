using GildedRose.Inventory.Items;

namespace GildedRose.Inventory.ItemCategorization
{
    public interface IItemCategorizer
    {
        IInnItem Categorize(Item item);
    }
}