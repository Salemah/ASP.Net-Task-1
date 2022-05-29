using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cv2.Models;
namespace cv2.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Profile()
        {

            // ViewBag.name = "tanvir";
            //ewBag.id = "19";
            //  ViewBag.dpt = "cse";
            // String [] name = { "tanvir", "rakib", "jubayer" };
            // ViewBag.names = name;
            Person pf = new Person()
            {
                Name = "tanvir",
                Id = 12
            };
            return View(pf);
        }
        public ActionResult Register()
        {

            TempData["msg"] = "registration succesfull";
            return RedirectToAction("Profile");
        }
    }
}