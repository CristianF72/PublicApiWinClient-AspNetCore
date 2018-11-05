using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
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
            Currency currency = (Currency)GetCurrency();

            ViewData["myModel"] = currency;

            return View();
        }

        public object GetCurrency()
        {
            string appid = "82317600e69a22e0938a30092fbfa178";
            string url = "http://data.fixer.io/api/latest?access_key=" + appid;
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            //var serializer = new JavaScriptSerializer();
            var jsonContent = JsonConvert.DeserializeObject<Currency>(content);
            return jsonContent;

            
        }
        [HttpPost]
        public ActionResult CurrencyConversion(Currency model, FormCollection form)
        {
            //Currency currency = (Currency)GetCurrency();

            CurrencyConversion.CurrencyConversion currencyConversion = new CurrencyConversion.CurrencyConversion();

            decimal czk = model.Rates["CZK"];
            decimal gbp = model.Rates["GBP"];
            decimal ron = model.Rates["RON"];
            decimal eur = model.Rates["EUR"];

            dynamic valueForConversion = form["valueForConversion"];

            string fromCurrency = form["fromCurrency"];

            string toCurrency = form["toCurrency"];

            model.ValueAfterConversion = currencyConversion.ConverseCurrency(fromCurrency, toCurrency, valueForConversion.Value, czk, gbp, ron, eur);

            //ViewData["myModel"] = currency;

            return View(model);
        }

    }
}