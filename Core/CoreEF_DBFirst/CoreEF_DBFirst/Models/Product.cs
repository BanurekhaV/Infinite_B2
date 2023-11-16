using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductSales = new HashSet<ProductSale>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Price { get; set; }
        public int? QuantityAvailable { get; set; }

        public virtual ICollection<ProductSale> ProductSales { get; set; }
    }
}
