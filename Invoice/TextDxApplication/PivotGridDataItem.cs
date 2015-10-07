using System;
using System.Collections.Generic;
using System.Text;

namespace TextDxApplication {
    public class PivotGridDataItem {
        string product;
        double price;
        DateTime date;

        public string Product { get { return product; } }
        public double Price { get { return price; } }
        public DateTime Date { get { return date; } }

        public PivotGridDataItem(string product, double price, DateTime date) {
            this.product = product;
            this.price = price;
            this.date = date;
        }
    }
}
