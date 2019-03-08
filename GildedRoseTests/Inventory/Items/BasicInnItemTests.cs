using System;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Items
{
    [TestFixture]
    public class BasicInnItemTests
    {
        [Test]
        public void Update_SellInDecreasses()
        {
            // Arrange
            var item = new BasicInnItem("Foo", 0, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.SellIn == -1);
        }

        [Test]
        public void Update_PositiveSellIn_QualityDecreassesByOne()
        {
            // Arrange
            var item = new BasicInnItem("Foo", 1, 10);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 10 - 1);
        }

        [Test]
        public void Update_NegativeSellIn_QualityDecreassesByOne()
        {
            // Arrange
            var item = new BasicInnItem("Foo", -1, 10);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 10 - 2);
        }
    }
}
