using KarcicegiYayinVeDagitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KarcicegiYayinVeDagitim.Controllers
{
    public class AdminHomeController : Controller
    {
        [Authorize]
        // GET: AdminHome
        public ActionResult Index()
        {
            return View(new State().GetModelState() );
        }
    }
}