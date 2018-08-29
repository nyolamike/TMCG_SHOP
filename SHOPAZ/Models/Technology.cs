using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Technology
    {
        public int TechnologyId { get; set; }
        public string Name { get; set; }

        ICollection<Product> Products { get; set; }
    }
}