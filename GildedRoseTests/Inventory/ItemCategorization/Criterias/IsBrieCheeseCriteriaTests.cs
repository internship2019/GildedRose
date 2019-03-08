using System;
using GildedRose;
using GildedRose.Inventory.ItemCategorization.Criterias;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Criterias
{
    [TestFixture]
    public class IsBrieCheeseCriteriaTests
    {
        [Test]
        public void Is_ReturnBetterByAgeItem()
        {
            // Arrange
            var criteria = new IsBrieCheeseCriteria();
            var testItem = new Item("Some nice bRiE cheese", 42, 42);

            // Act
            var output = criteria.TryCategorize(testItem);

            // Assert
            Assert.IsNotNull(output);
            Assert.IsInstanceOf<BetterByAgeItem>(output);
        }

        [Test]
        public void IsNot_ReturnNull()
        {
            // Arrange
            var criteria = new IsBrieCheeseCriteria();
            var testItem = new Item("Some nonBrie cheese", 42, 42);

            // Act
            var output = criteria.TryCategorize(testItem);

            // Assert
            Assert.IsNull(output);
        }
    }
}
