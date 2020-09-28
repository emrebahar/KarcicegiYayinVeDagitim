using KarcicegiYayinVeDagitim.Entity;
using KarcicegiYayinVeDagitim.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KarcicegiYayinVeDagitim.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urun = db.Products.Where(i => i.IsHome && i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description.Length > 25 ? i.Description.Substring(0, 20) + "..." : i.Description,
                Class = i.Class,
                Price = i.Price,
                Stok = i.Stok,
                Image = i.Image,
                CategoryId = i.CategoryId
            }).ToList();
            return View(urun);
        }
        public PartialViewResult Slider()
        {
            return PartialView(db.Products.Where(x => x.Slider && x.IsApproved).Take(5).ToList());
        }
        public PartialViewResult FeaturedProductList()
        {
            return PartialView(db.Products.Where(x => x.Isfeatured && x.IsApproved).Take(5).ToList());
        }
        public ActionResult ProductList(int id )
        {
            return View(db.Products.Where(i => i.CategoryId == id).ToList());
        }
        public ActionResult ProductDetails(int id)
        {
            return View(db.Products.Where(x => x.Id == id).FirstOrDefault());
        }
        public ActionResult Search(string q)
        {
            var arama = db.Products.Where(x => x.IsApproved == true);
            if (string.IsNullOrEmpty(q))
            {
                arama.Where(i => i.Name.Contains(q) || i.Description.Contains(q));
            }
            return View(arama.ToList());
        }
        public ActionResult Product()
        {
            var urun = db.Products.Where(i => i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description.Length > 25 ? i.Description.Substring(0, 20) + "..." : i.Description,
                Class = i.Class,
                Price = i.Price,
                Stok = i.Stok,
                Image = i.Image,
                CategoryId = i.CategoryId
            }).ToList();
            return View(urun);
        }



    }
}