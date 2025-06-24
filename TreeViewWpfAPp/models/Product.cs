﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewWpfAPp.models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public Dictionary<int, Product> Products { get; set; }
        public Product()
        {
            Products = new Dictionary<int, Product>();
        }
    }
}
