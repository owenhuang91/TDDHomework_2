﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart {
    public class ShoppingCart {
        public int CaculatePrice(List<Book> books) {

            int totalPrice = 0;
            decimal rawPrice = 0;
            decimal percent = 1;

            while (books.Any(m => m.Amount != 0)) {

                var needDiscountedBooks = books.Where(m => m.Amount > 0);

                percent = GetDiscountedPercent(needDiscountedBooks.Count());
                rawPrice += needDiscountedBooks.Sum(m => m.Price) * percent;
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