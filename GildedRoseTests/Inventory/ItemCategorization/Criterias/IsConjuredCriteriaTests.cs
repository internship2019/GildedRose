using System;
using GildedRose;
using GildedRose.Inventory.ItemCategorization.Criterias;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Criterias
{
    [TestFixture]
    public class IsConjuredCriteriaTests
    {
        [Test]
        public void Is_ReturnConjuredItem()
        {
            // Arrange
            var criteria = new IsConjuredCriteria();
            var testItem = new Item("A Conjured item", 42, 42);

            // Act
            var output = criteria.TryCategorize(testItem);

            // Assert
            Assert.IsNotNull(output);
            Assert.IsInstanceOf<ConjuredItem>(output);
        }

        [Test]
        public void IsNot_ReturnNull()
        {
            // Arrange
            var criteria = new IsConjuredCriteria();
            var testItem = new Item("A Nonconjured item", 42, 42);

            // Act
            var output = criteria.TryCategorize(testItem);

            // Assert
            Assert.IsNull(output);
        }
    }
}
