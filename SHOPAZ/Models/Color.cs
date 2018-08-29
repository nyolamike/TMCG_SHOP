using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Color
    {

        public int ColorId { get; set; }
        public string Name { get; set; }

        ICollection<Product> Products { get; set; }
    }
}