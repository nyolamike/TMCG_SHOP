using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class ProductGrouping
    {
        public int ProductGroupingId { get; set; }
        public int ProductId { get; set; }
        public int GroupingId { get; set; }

        public Product Product { get; set; }
        public Grouping Grouping { get; set; }
    }
}