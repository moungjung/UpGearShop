﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGearShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool NewProduct { get; set; }
        //public int CategoryId { get; set; }

        //public string CategoryName { get; set; }
        //public string imageUrl { get; set; }
    }
}