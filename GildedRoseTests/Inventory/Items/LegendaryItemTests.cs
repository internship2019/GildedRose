using System;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Items
{
    [TestFixture]
    public class LegendaryItemTests
    {
        [Test]
        public void Update_NothingChanges()
        {
            // Arrange
            var item = new LegendaryItem("Foo");
            var initialSellIn = item.SellIn;
            var initialQuality = item.Quality;

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.SellIn == initialSellIn);
            Assert.IsTrue(item.Quality == initialQuality);
        }
    }
}
