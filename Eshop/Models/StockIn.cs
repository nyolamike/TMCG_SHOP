﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class StockIn
    {
        public int StockInId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }

        public DateTime EntryDate { get; set; }

        public Product Product { get; set; }
    }
}