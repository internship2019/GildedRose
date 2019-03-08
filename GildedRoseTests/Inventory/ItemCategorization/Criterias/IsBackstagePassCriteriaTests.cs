using System;
using GildedRose;
using GildedRose.Inventory.ItemCategorization.Criterias;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Criterias
{
    [TestFixture]
    public class IsBackstagePassCriteriaTests
    {
        [Test]
        public void Is_ReturnBackstageCriteria()
        {
            // Arrange
            var criteria = new IsBackstagePassCriteria();
            var testItem = new Item("Backstage pass to a nice concert", 42, 42);

            // Act
            var output = criteria.TryCategorize(testItem);

            // Assert
            Assert.IsNotNull(output);
            Assert.IsInstanceOf<BackstagePassItem>(output);
        }

        [Test]
        public void IsNot_ReturnNull()
        {
            // Arrange
            var criteria = new IsBackstagePassCriteria();
            var testItem = new Item("Frontstage pass to a nice concert", 42, 42);

            // Act
            var output = criteria.TryCategorize(testItem);

            // Assert
            Assert.IsNull(output);
        }
    }
}
