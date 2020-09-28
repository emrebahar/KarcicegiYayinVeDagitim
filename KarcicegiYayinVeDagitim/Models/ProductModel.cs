﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarcicegiYayinVeDagitim.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Class { get; set; }
        public double Price { get; set; }
        public int Stok { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
    }
}