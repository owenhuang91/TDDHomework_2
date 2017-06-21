using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart {
    public class ShoppingCart {

        private Dictionary<int, decimal> discountPercent;

        public ShoppingCart() {
            discountPercent = new Dictionary<int, decimal>()
            {
                {1,1},
                {2,0.95m},
                {3,0.9m},
                {4,0.8m},
                {5,0.75m}
            };
        }

        public int CaculatePrice(List<Book> books) {

            decimal rawPrice = 0;
            decimal dicountPercent = 1;

            //執行迴圈直到所有書的數量都為0為止
            while (books.Any(m => m.Amount != 0)) {

                //找出這一次有哪幾本書可以一起算折扣
                var needDiscountedBooks = books.Where(m => m.Amount > 0);

                dicountPercent = discountPercent[needDiscountedBooks.Count()];
                rawPrice += needDiscountedBooks.Sum(m => m.Price) * dicountPercent;

                //將剛剛已經計算過價格的書扣除
                books.ForEach(m => { if (m.Amount > 0) m.Amount--; });
            }

            int totalPrice = Convert.ToInt32(Math.Round(rawPrice, 0, MidpointRounding.AwayFromZero));

            return totalPrice;
        }
    }

    public class Book {
        public int Price { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
    }
}