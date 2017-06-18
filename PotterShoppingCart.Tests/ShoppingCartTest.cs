using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests {
    /// <summary>
    /// 第一集買了一本，其他都沒買，價格應為100*1=100元 的摘要說明
    /// </summary>
    [TestClass]
    public class ShoppingCartTest {
        /// <summary>
        /// 第一集買了一本，其他都沒買，價格應為100*1=100元
        /// </summary>
        [TestMethod]
        public void Buy_first_episode_count_1_should_return_100() {

            //arrange
            var target = new ShoppingCart();
            var expected = 100;
            var firstEpisode = new HarryPotterFirstEpisode() { Price = 100, Amount = 1 };

            //act
            int actual = target.CaculatePrice(new List<Book>() { firstEpisode });

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
        /// </summary>
        [TestMethod]
        public void Buy_first_episode_count_1_and_second_episode_count_1_should_return_190() {

            //arrange
            var target = new ShoppingCart();
            var expected = 190;
            var firstEpisode = new HarryPotterFirstEpisode() { Price = 100, Amount = 1 };
            var secondEpisod = new HarryPotterSecondEpisode() { Price = 100, Amount = 1 };
            //act
            int actual = target.CaculatePrice(new List<Book>() { firstEpisode, secondEpisod });

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
