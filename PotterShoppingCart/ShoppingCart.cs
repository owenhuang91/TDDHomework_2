using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart {
    public class ShoppingCart {
        public int CaculatePrice(IEnumerable<Book> books) {
            int totalPrice = 0;
            return totalPrice;
        }
    }


    public abstract class Book {
        public abstract int Price { get; set; }
        public abstract int Count { get; set; }
    }

    public class HarryPotterFirstEpisode : Book {
        public override int Price { get; set; }
        public override int Count { get; set; }
    }
}