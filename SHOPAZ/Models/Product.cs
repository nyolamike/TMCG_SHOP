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

        public double AlertLimit { get; set; }

        public double QuantityRemaining { get; set; }

        public double SellingPrice { get; set; }

        #region navigational_Properties

        public Category Category { get; set; }
        public Brand Brand { get; set; }

        public Size Size { get; set; }

        public Style Style { get; set; }

        public Color Color { get; set; }

        public Material Material { get; set; }

        public Technology Technology { get; set; }

        public ICollection<StockIn> StockIns { get; set; }

        public ICollection<StockOut> StockOuts { get; set; }

        ICollection<ProductGrouping> ProductGroupings { get; set; }

        #endregion  navigational_Properties
    }
}