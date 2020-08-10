using KarcicegiYayinVeDagitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KarcicegiYayinVeDagitim.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public PartialViewResult BildirimMenusu()
        {
            return PartialView(new Bildirim().SiparisBekleyenListe());
        }
    }
}