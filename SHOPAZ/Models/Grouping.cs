using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHOPAZ.Models
{
    public class Grouping
    {
        public int GroupingId { get; set; }
        public string Name { get; set; }

        ICollection<ProductGrouping> ProductGroupings { get; set; }
    }
}