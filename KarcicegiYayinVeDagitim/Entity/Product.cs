using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace KarcicegiYayinVeDagitim.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stok { get; set; }
        public string Image { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public bool Isfeatured { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public object ProductModel { get; internal set; }
    }
}