using System;
using GildedRose;
using GildedRose.Inventory.ItemCategorization.Criterias;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Criterias
{
    [TestFixture]
    public class IsLegendaryCriteriaTests
    {
        [Test]
        public void Is_ReturnLegendaryItem()
        {
            // Arrange
            var criteria = new IsLegendaryCriteria();
            var testItem = new Item("Sulfuras whatever", 42, 42);

            // Act
            var output = criteria.TryCategorize(testItem);

            // Assert
            Assert.IsNotNull(output);
            Assert.IsInstanceOf<LegendaryItem>(output);
        }

        [Test]
        public void IsNot_ReturnNull()
        {
            // Arrange
            var criteria = new IsLegendaryCriteria();
            var testItem = new Item("A piece of crap", 42, 42);

            // Act
            var output = criteria.TryCategorize(testItem);

            // Assert
            Assert.IsNull(output);
        }
    }
}
