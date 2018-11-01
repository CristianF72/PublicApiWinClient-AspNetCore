using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PublicApi_AspNetCore_Client.Models;

namespace PublicApi_AspNetCore_Client.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CurrencyConversion()
        {
            return View();
        }

        public JsonResult GetCurrency()
        {
            Currency currency = new Currency();
            return Json(currency.getCurrencyFromFixerIo(),JsonRequestBehavior.AllowGet);
        }

        public void GetConversion()
        {
           // string fromCurrency = 
        }

    }
}