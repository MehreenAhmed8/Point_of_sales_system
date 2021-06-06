using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Database
{
    public class Data
    {
        public Data(string ItemName,string quantity)
        {
            
            this.Name = ItemName;
            this.QTY = quantity;
        }
        public string Name { get; set; }
        public string QTY { get; set; }
     

    }
}
