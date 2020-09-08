using OutputCacheFilterMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCacheFilterMVC.Controllers
{
    
    public class HomeController : Controller
    {
        PersonDBEntities db = new PersonDBEntities();
        // GET: Home
        [OutputCache(Duration =10, Location = System.Web.UI.OutputCacheLocation.Client)]
        //when action mathod call next 10 second DateTime will be save. if we will call after 10 second DateTime will Update
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }

        [OutputCache(Duration = 30)]
        public ActionResult GetData()
        {
            var data = db.people.ToList();
            return View(data);
        }
    }
}