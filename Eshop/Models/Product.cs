using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SizeId { get; set; }
        public int StyleId { get; set; }
        public int ColorId { get; set; }
        public int MaterialId { get; set; }

        public int TechnologyId { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        #region navigational_Properties

        public Category Category { get; set; }
        public Brand Brand { get; set; }

        public Size Size { get; set; }

        public Style Style { get; set; }

        public Color Color { get; set; }

        public Material Material { get; set; }

        public Technology Technology { get; set; }

        #endregion  navigational_Properties
    }
}