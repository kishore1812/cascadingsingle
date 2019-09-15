using cascadingtask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cascadingtask.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities1 db = new Database1Entities1();
        public ActionResult Index()
        {


            List<country> CountryList = db.countries.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "countryid", "countryname");
            return View();
        }
         
        public JsonResult GetStateList(int countryid)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<state> StateList = db.states.Where(X => X.Refcountryid == countryid).ToList();
            return Json(StateList, JsonRequestBehavior.AllowGet);
        }
       
    }
}