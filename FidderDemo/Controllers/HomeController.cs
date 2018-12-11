using FidderDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FidderDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
           
            ViewBag.nu = DateTime.Now.ToLongTimeString();
            return View();
        }

        // GET: Home
        [HttpGet]
        public ActionResult RetPerson()
        {

            string sti = Server.MapPath("~/app_data/person.json");
            Person p;
            if (System.IO.File.Exists(sti))
            {
                string indhold = System.IO.File.ReadAllText(sti);
                p = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(indhold);
            }
            else
            {
                p = new Person() { Id = 1 };
            }
            return View(p);
        }

        [HttpPost]
        public ActionResult RetPerson(Person p)
        {
            // Gem
           
             if(ModelState.IsValid)
            { 
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(p);

            string sti = Server.MapPath("~/app_data/person.json");

            System.IO.File.WriteAllText(sti, json);
            }


            return View();
        }
    }
}