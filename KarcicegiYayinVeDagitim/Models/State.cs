using KarcicegiYayinVeDagitim.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarcicegiYayinVeDagitim.Models
{
    public class State
    {
        DataContext db = new DataContext();
        public StateModelStyle GetModelState()
        {
            StateModelStyle models = new StateModelStyle();
            models.BekleyenSiparisSayisi = db.Orders.Where(i => i.OrderState == EnumOrderState.Bekleniyor).ToList().Count;
            models.KargolananSiparisSayisi = db.Orders.Where(i => i.OrderState == EnumOrderState.Kargolandı).ToList().Count;
            models.TamamlananSiparisSayisi = db.Orders.Where(i => i.OrderState == EnumOrderState.Tamamlandı).ToList().Count;
            models.PaketlenenSiparisSayisi = db.Orders.Where(i => i.OrderState == EnumOrderState.Paketlendi).ToList().Count;
            models.UrunSayisi = db.Products.Count();
            models.SiparisSayisi = db.Orders.Count();
            return models;
        }
    }
    public class StateModelStyle
    {
        public int UrunSayisi { get; set; }
        public int SiparisSayisi { get; set; }
        public int BekleyenSiparisSayisi { get; set; }
        public int KargolananSiparisSayisi { get; set; }
        public int TamamlananSiparisSayisi { get; set; }
        public int PaketlenenSiparisSayisi { get; set; }
    }
}