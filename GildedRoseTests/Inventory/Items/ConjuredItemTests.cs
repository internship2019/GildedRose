using System;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Items
{
    [TestFixture]
    public class ConjuredItemTests
    {
        [Test]
        public void Update_SellInDecreasses()
        {
            // Arrange
            var item = new ConjuredItem("Foo", 0, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.SellIn == -1);
        }

        [Test]
        public void Update_QualityDecreassesBy2()
        {
            // Arrange
            var item = new ConjuredItem("Foo", 42, 10);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 10 - 2);
        }
    }
}
