using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarcicegiYayinVeDagitim.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name  = "ARI" , Description="Ari Yayinlari"},
                new Category() {Name= "MODEL", Description="Model Yayinlari"},
                new Category(){Name ="HIZ", Description="Hiz Yayinlari"}
            };
            foreach (var item  in kategoriler)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name ="8. Sınıf deneme Matematik",Description="kitap",Price=30,Stok=50,IsHome=true,CategoryId=1,Image="var1.png",IsApproved=true,Isfeatured=false},
                new Product(){Name ="8. Sınıf deneme",Description="kitap",Price=30,Stok=50,IsHome=true,CategoryId=1,Image="var2.png",IsApproved=true,Isfeatured=false},
                new Product(){Name ="8. Sınıf deneme",Description="kitap",Price=30,Stok=50,IsHome=true,CategoryId=1,Image="model1.png",IsApproved=true,Isfeatured=false},
                new Product(){Name ="8. Sınıf deneme",Description="kitap",Price=30,Stok=50,IsHome=false,CategoryId=1,Image="model2.png",IsApproved=true,Isfeatured=false}
            };
            foreach (var item in urunler)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}