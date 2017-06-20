using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart {
    public class ShoppingCart {
        public int CaculatePrice(List<Book> books) {

            int totalPrice = 0;
            decimal rawPrice = 0;
            decimal dicountPercent = 1;

            //執行迴圈直到所有書的數量都為0為止
            while (books.Any(m => m.Amount != 0)) {

                //找出這一次有哪幾本書可以一起算折扣
                var needDiscountedBooks = books.Where(m => m.Amount > 0);

                dicountPercent = GetDiscountedPercent(needDiscountedBooks.Count());
                rawPrice += needDiscountedBooks.Sum(m => m.Price) * dicountPercent;

                //將剛剛已經計算過價格的書扣除
                books.ForEach(m => { if (m.Amount > 0) m.Amount--; });
            }

            totalPrice = Convert.ToInt32(Math.Round(rawPrice, 0, MidpointRounding.AwayFromZero));

            return totalPrice;
        }

        private decimal GetDiscountedPercent(int booksAmount) {

            decimal percent = 1;

            switch (booksAmount) {
                case 1:
                    percent = 1;
                    break;
                case 2:
                    percent = 0.95m;
                    break;
                case 3:
                    percent = 0.9m;
                    break;
                case 4:
                    percent = 0.8m;
                    break;
                case 5:
                    percent = 0.75m;
                    break;
                default:
                    break;
            }
            return percent;
        }
    }

    public class Book {
        public int Price { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
    }
}