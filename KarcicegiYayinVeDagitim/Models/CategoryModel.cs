using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarcicegiYayinVeDagitim.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int Class { get; internal set; }
    }
}