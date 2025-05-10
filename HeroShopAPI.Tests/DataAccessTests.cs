//using HeroShopAPI.Tests;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NSubstitute;
//using System.Collections.Generic;
//using System.Linq;

//namespace YourNamespace.Tests
//{
//    [TestClass]
//    public class DataAccessTests
//    {
//        private IDataAccess _mockDataAccess;

//        [TestInitialize]
//        public void Setup()
//        {
//            _mockDataAccess = Substitute.For<IDataAccess>();

//            var mockItems = new List<Item>
//            {
//                new Item { ItemId = 1, CategoryId = 1, Category = "All", Title = "Item 1", Description = "Desc", IconUrl = "url", Price = 1, Weight = 1 },
//                new Item { ItemId = 2, CategoryId = 1, Category = "All", Title = "Item 2", Description = "Desc", IconUrl = "url", Price = 1, Weight = 1 },
//                new Item { ItemId = 3, CategoryId = 1, Category = "All", Title = "Item 3", Description = "Desc", IconUrl = "url", Price = 1, Weight = 1 },
//                new Item { ItemId = 4, CategoryId = 1, Category = "All", Title = "Item 4", Description = "Desc", IconUrl = "url", Price = 1, Weight = 1 },
//                new Item { ItemId = 5, CategoryId = 1, Category = "All", Title = "Item 5", Description = "Desc", IconUrl = "url", Price = 1, Weight = 1 },
//                new Item { ItemId = 6, CategoryId = 1, Category = "All", Title = "Item 6", Description = "Desc", IconUrl = "url", Price = 1, Weight = 1 },
//                new Item { ItemId = 7, CategoryId = 1, Category = "All", Title = "Item 7", Description = "Desc", IconUrl = "url", Price = 1, Weight = 1 },
//                new Item { ItemId = 8, CategoryId = 1, Category = "All", Title = "Item 8", Description = "Desc", IconUrl = "url", Price = 1, Weight = 1 }
//            };

//            _mockDataAccess.GetItems().Returns(mockItems);
//        }

//        [TestMethod]
//        public void GetItems_Returns_ExpectedItemCount()
//        {
//            // Act
//            var items = _mockDataAccess.GetItems();

//            // Assert
//            Assert.IsNotNull(items);
//            Assert.AreEqual(8, items.Count);
//        }

//        [TestMethod]
//        public void GetItems_Fields_AreNotNullOrEmpty()
//        {
//            // Act
//            var items = _mockDataAccess.GetItems();

//            // Assert
//            foreach (var item in items)
//            {
//                Assert.IsTrue(item.ItemId > 0);
//                Assert.IsTrue(item.CategoryId > 0);
//                Assert.IsFalse(string.IsNullOrWhiteSpace(item.Category));
//                Assert.IsFalse(string.IsNullOrWhiteSpace(item.Title));
//                Assert.IsFalse(string.IsNullOrWhiteSpace(item.Description));
//                Assert.IsFalse(string.IsNullOrWhiteSpace(item.IconUrl));
//                Assert.IsTrue(item.Price >= 0);
//                Assert.IsTrue(item.Weight > 0);
//            }
//        }
//    }
//}
