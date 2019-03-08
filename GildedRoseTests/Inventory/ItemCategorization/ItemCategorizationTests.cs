using GildedRose;
using GildedRose.Inventory.ItemCategorization;
using GildedRose.Inventory.ItemCategorization.Criterias;
using GildedRose.Inventory.Items;
using NSubstitute;
using NUnit.Framework;

namespace GildedRoseTests.Inventory
{
    [TestFixture]
    public class ItemCategorizationTests
    {
        [Test]
        public void Categorize_NoCriterias_GiveBasicItem()
        {
            // Arrange
            var categorizer = new ItemCategorizer(new ICategorizationCriteria[] { });
            var testItem = new Item("Foo", 0, 0);

            // Act
            var categorizedItem = categorizer.Categorize(testItem);

            // Assert
            Assert.IsInstanceOf<BasicInnItem>(categorizedItem);
        }

        [Test]
        public void Categorize_CriteriaReturnsItem_ReturnThatItem()
        {
            // Arrange
            var targetToReturn = Substitute.For<IInnItem>();

            var criteria = Substitute.For<ICategorizationCriteria>();
            criteria.TryCategorize(Arg.Any<Item>()).Returns(targetToReturn);

            var categorizer = new ItemCategorizer(new ICategorizationCriteria[] { criteria });
            var testItem = new Item("Foo", 0, 0);

            // Act
            var categorizedItem = categorizer.Categorize(testItem);

            // Assert
            Assert.AreSame(categorizedItem, targetToReturn);
        }
    }
}
