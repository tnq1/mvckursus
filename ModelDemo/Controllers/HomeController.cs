using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ModelDemo.Models.Person p = new Models.Person();
            p.Alder = 10;
            p.Navn = "Mathias";
            p.ErIliv = true;

            return View(p);
        }

        public ActionResult Index2(ModelDemo.Models.Person person)
        {
            ModelDemo.Models.Person p = new Models.Person();
            p.Alder = 10;
            p.Navn = "Mathias";
            p.ErIliv = true;

            return View(p);
        }

        public ActionResult Login(ModelDemo.Models.LoginViewModel l)
            
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("index");
            }
            else
            {

                return View();
            }
        }
    }
}