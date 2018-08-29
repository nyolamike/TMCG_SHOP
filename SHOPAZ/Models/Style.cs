using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Style
    {

        public int StyleId { get; set; }
        public string Name { get; set; }

        ICollection<Product> Products { get; set; }
    }
}