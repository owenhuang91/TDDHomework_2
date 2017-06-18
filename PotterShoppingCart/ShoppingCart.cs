﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart {
    public class ShoppingCart {
        public int CaculatePrice(IEnumerable<Book> books) {

            int totalPrice = 0;
            double percent = 1;

            //折扣
            switch (books.Count()) {
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

    public class HarryPotterFourthEpisode : Book {
        public override int Price { get; set; }
    }

    public class HarryPotterFifthEpisode : Book {
        public override int Price { get; set; }
    }
}