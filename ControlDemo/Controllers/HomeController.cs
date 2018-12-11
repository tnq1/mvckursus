using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test1()
        {

            return Content("1345");
        }
        public ActionResult Test2()
        {

            return Content("1345","application/CSV");
        }
        public ActionResult Test3()
        {

           // return Redirect("http://www.google.dk");
            return Redirect("http://www.google.dk");
        }
        public ActionResult Test4()
        {

            // return Redirect("http://www.google.dk");
            return RedirectToAction("index");
        }
        public ActionResult Test5()
        {


            return Json(Person.Personer(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Test6()
        {

            return View();
        }
        public ActionResult Test8()
        {

            string t = Guid.NewGuid().ToString();
            ViewBag.streng = t;
            ViewBag.id = 1;
            return View();
        }

      
       public ActionResult Test9()
        {
            string t = Guid.NewGuid().ToString();
            Test9ViewModel m = new Test9ViewModel
            {
                Id = 1,
                Streng = t
            };
            return View(m);
        }
        public ActionResult Test10(string test, int tal=0)
        {
           
            return View();
        }

        public ActionResult Test11(Person p)
        {

            return View();
        }

        public ActionResult Test12(Person p)
        {
            if (!ModelState.IsValid){ } else { }
            return View();
        }
    }
    public class Test9ViewModel
    {
        public int Id { get; set; }
        public string Streng { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Alder { get; set; }


        public static List<Person> Personer()
        {
            List<Person> p = new List<Person>()
            {
                //new Person(){ Id=1, Alder = 10, Navn = "asdf"},
                //new Person(){ Id=2, Alder = 30, Navn = "sdfdfsghegsgd"},
                //new Person(){ Id=3, Alder = 40, Navn = "dæflkgj lsdfkj lsdfkj dlsj"}
                new Person(){ Id=1, Alder = 10, Navn = Guid.NewGuid().ToString()},
                new Person(){ Id=2, Alder = 30, Navn = Guid.NewGuid().ToString()},
                new Person(){ Id=3, Alder = 40, Navn = Guid.NewGuid().ToString()}
            };
            return p;
        }
    }
}