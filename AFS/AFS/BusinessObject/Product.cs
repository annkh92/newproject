using System;
using System.Collections.Generic;
using System.Text;

namespace AFS
{
    class Product
    {
        public string prodname { get; set; }
        public string category { get; set; }
        public string supplier { get; set; }
        public string unitprice { get; set; }
        public string quantity { get; set; }
        public string instock { get; set; }
        public string onorder { get; set; }
        public string reorderlevel { get; set; }

        public Product(string prodname, string category, string supplier, string unitprice, string quantity, string instock, string onorder, string reorderlevel)
        {
            this.prodname = prodname;
            this.category = category;
            this.supplier = supplier;
            this.unitprice = unitprice;
            this.quantity = quantity;
            this.instock = instock;
            this.onorder = onorder;
            this.reorderlevel = reorderlevel;
        }
    }
}
