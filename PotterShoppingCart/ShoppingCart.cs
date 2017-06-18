using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart {
    public class ShoppingCart {
        public int CaculatePrice(IEnumerable<Book> books) {

            int totalPrice = 0;
            double percent = 1;

            //折扣
            if (books.Count() > 1) {
                percent = 0.95;
            }
            double rawPrice = books.Sum(m => m.Price * m.Amount) * percent;
            totalPrice = Convert.ToInt32(Math.Round(rawPrice, 0, MidpointRounding.AwayFromZero));

            return totalPrice;
        }
    }

    public abstract class Book {
        public abstract int Price { get; set; }
        public int Amount { get; set; }
    }

    public class HarryPotterFirstEpisode : Book {
        public override int Price { get; set; }
    }

    public class HarryPotterSecondEpisode : Book {
        public override int Price { get; set; }
    }

    public class HarryPotterThirdEpisode : Book {
        public override int Price { get; set; }
    }
}