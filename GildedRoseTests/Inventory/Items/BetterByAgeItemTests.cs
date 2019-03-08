
using System;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Items
{
    [TestFixture]
    public class BetterByAgeItemTests
    {
        [Test]
        public void Update_SellInDecreasses()
        {
            // Arrange
            var item = new BetterByAgeItem("Foo", 0, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.SellIn == -1);
        }

        [Test]
        public void Update_PositiveSellIn_QualityIncreassesByOne()
        {
            // Arrange
            var item = new BetterByAgeItem("Foo", 1, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 1);
        }

        [Test]
        public void Update_NegativeSellIn_QualityIncreassesByTwo()
        {
            // Arrange
            var item = new BetterByAgeItem("Foo", -1, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 2);
        }
    }
}
