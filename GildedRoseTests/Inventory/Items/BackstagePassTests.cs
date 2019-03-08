using System;
using GildedRose.Inventory.Items;
using NUnit.Framework;

namespace GildedRoseTests.Inventory.Items
{
    [TestFixture]
    public class BackstagePassTests
    {
        [Test]
        public void Update_SellInDecreasses()
        {
            // Arrange
            var item = new BackstagePassItem("Foo", 42, 42);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.SellIn == 42 - 1);
        }

        [Test]
        public void Update_SellInBiggerThan10Days_QualityIncreasedByOne()
        {
            // Arrange
            var item = new BackstagePassItem("Foo", 11, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 1);
        }

        [Test]
        public void Update_SellInInside10Days_QualityIncreasedBy2()
        {
            // Arrange
            var item = new BackstagePassItem("Foo", 6, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 2);
        }

        [Test]
        public void Update_SellInInside5Days_QualityIncreasedBy3()
        {
            // Arrange
            var item = new BackstagePassItem("Foo", 1, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 3);
        }

        [Test]
        public void Update_SellInIsZero_QualityIsZero()
        {
            // Arrange
            var item = new BackstagePassItem("Foo", 0, 0);

            // Act
            item.Update();

            // Assert
            Assert.IsTrue(item.Quality == 0);
        }
    }
}
