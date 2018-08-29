using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHOPAZ.Models
{
    public class Size
    {
        public int SizeId { get; set; }
        public string Name { get; set; }

        ICollection<Product> Products { get; set; }
    }
}