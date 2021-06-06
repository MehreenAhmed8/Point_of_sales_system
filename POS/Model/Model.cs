using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    class Item
    {
        public Item(string Items, string price, string total)
        {
            q++;
            this.Items = Items;
            this.Price = price;
            this.Total = total;
            this.QTY = q.ToString();
        }
        public string Items { get; set; }
        public string Price { get; set; }
        public string QTY { get; set; }
        public string Total { get; set; }
        public int q = 0;

    }
}
