using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart {
    public class ShoppingCart {
        public int CaculatePrice(List<Book> books) {

            int totalPrice = 0;
            double rawPrice = 0;
            double percent = 1;

            while (books.Any(m => m.Amount != 0)) {
                var needCaculateBooks = books.Where(m => m.Amount > 0);
                percent = GetDiscountPercent(needCaculateBooks.Count());
                rawPrice += needCaculateBooks.Sum(m => m.Price) * percent;
                books.ForEach(m => { if (m.Amount > 0) m.Amount--; });
            }

            totalPrice = Convert.ToInt32(Math.Round(rawPrice, 0, MidpointRounding.AwayFromZero));

            return totalPrice;
        }

        private double GetDiscountPercent(int amount) {

            double percent = 1;

            switch (amount) {
                case 1:
                    percent = 1;
                    break;
                case 2:
                    percent = 0.95;
                    break;
                case 3:
                    percent = 0.9;
                    break;
                case 4:
                    percent = 0.8;
                    break;
                case 5:
                    percent = 0.75;
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
    }

    public class HarryPotterFirstEpisode : Book {
    }

    public class HarryPotterSecondEpisode : Book {
    }

    public class HarryPotterThirdEpisode : Book {
    }

    public class HarryPotterFourthEpisode : Book {
    }

    public class HarryPotterFifthEpisode : Book {
    }
}