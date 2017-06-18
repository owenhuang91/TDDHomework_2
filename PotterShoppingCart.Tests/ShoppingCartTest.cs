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

        /// <summary>
        /// 一二三集各買了一本，價格應為100*3*0.9=270
        /// </summary>
        [TestMethod]
        public void Buy_first_episode_count_1_and_second_episode_count_1_and_third_episode_count_1_should_return_270() {

            //arrange
            var target = new ShoppingCart();
            var expected = 270;
            var firstEpisode = new HarryPotterFirstEpisode() { Price = 100, Amount = 1 };
            var secondEpisod = new HarryPotterSecondEpisode() { Price = 100, Amount = 1 };
            var thirdEpisod = new HarryPotterThirdEpisode() { Price = 100, Amount = 1 };

            //act
            int actual = target.CaculatePrice(new List<Book>() { firstEpisode, secondEpisod, thirdEpisod });

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 一二三四集各買了一本，價格應為100*4*0.8=320
        /// </summary>
        [TestMethod]
        public void Buy_first_episode_count_1_and_second_episode_count_1_and_third_episode_count_1_and_fourth_episode_count_1_should_return_320() {

            //arrange
            var target = new ShoppingCart();
            var expected = 320;
            var firstEpisode = new HarryPotterFirstEpisode() { Price = 100, Amount = 1 };
            var secondEpisod = new HarryPotterSecondEpisode() { Price = 100, Amount = 1 };
            var thirdEpisod = new HarryPotterThirdEpisode() { Price = 100, Amount = 1 };
            var fourthEpisod = new HarryPotterFourthEpisode() { Price = 100, Amount = 1 };

            //act
            int actual = target.CaculatePrice(new List<Book>() { firstEpisode, secondEpisod, thirdEpisod, fourthEpisod });

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 一次買了整套，一二三四五集各買了一本，價格應為100*5*0.75=375
        /// </summary>
        [TestMethod]
        public void Buy_first_episode_count_1_and_second_episode_count_1_and_third_episode_count_1_and_fourth_episode_count_1_and_Fifth_episode_count_1_should_return_375() {

            //arrange
            var target = new ShoppingCart();
            var expected = 375;
            var firstEpisode = new HarryPotterFirstEpisode() { Price = 100, Amount = 1 };
            var secondEpisod = new HarryPotterSecondEpisode() { Price = 100, Amount = 1 };
            var thirdEpisod = new HarryPotterThirdEpisode() { Price = 100, Amount = 1 };
            var fourthEpisod = new HarryPotterFourthEpisode() { Price = 100, Amount = 1 };
            var fifthEpisod = new HarryPotterFifthEpisode() { Price = 100, Amount = 1 };

            //act
            int actual = target.CaculatePrice(new List<Book>() { firstEpisode, secondEpisod, thirdEpisod, fourthEpisod, fifthEpisod });

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// 一二集各買了一本，第三集買了兩本，價格應為100*3*0.9 + 100 = 370
        /// </summary>
        [TestMethod]
        public void Buy_first_episode_count_1_and_second_episode_count_1_and_third_episode_count_2_should_return_370() {

            //arrange
            var target = new ShoppingCart();
            var expected = 370;
            var firstEpisode = new HarryPotterFirstEpisode() { Price = 100, Amount = 1 };
            var secondEpisod = new HarryPotterSecondEpisode() { Price = 100, Amount = 1 };
            var thirdEpisod = new HarryPotterThirdEpisode() { Price = 100, Amount = 2 };

            //act
            int actual = target.CaculatePrice(new List<Book>() { firstEpisode, secondEpisod, thirdEpisod });

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 第一集買了一本，第二三集各買了兩本，價格應為100*3*0.9 + 100*2*0.95 = 460
        /// </summary>
        [TestMethod]
        public void Buy_first_episode_count_1_and_second_episode_count_2_and_third_episode_count_2_should_return_460() {

            //arrange
            var target = new ShoppingCart();
            var expected = 460;
            var firstEpisode = new HarryPotterFirstEpisode() { Price = 100, Amount = 1 };
            var secondEpisod = new HarryPotterSecondEpisode() { Price = 100, Amount = 2 };
            var thirdEpisod = new HarryPotterThirdEpisode() { Price = 100, Amount = 2 };

            //act
            int actual = target.CaculatePrice(new List<Book>() { firstEpisode, secondEpisod, thirdEpisod });

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
