using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class ProductSale
    {
        public int ProductSalesId { get; set; }
        public int? ProductId { get; set; }
        public int? QuantitySold { get; set; }

        public virtual Product Product { get; set; }
    }
}
