using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using PublicApi_AspNetCore_Client.Models;

namespace PublicApi_AspNetCore_Client.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [System.Web.Mvc.HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
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
        [System.Web.Mvc.HttpPost]
        public ActionResult CurrencyConversion([FromBody] Currency model)
        {
            //Currency model = (Currency)GetCurrency();

            CurrencyConversion.CurrencyConversion currencyConversion = new CurrencyConversion.CurrencyConversion();

            decimal czk = model.Rates["CZK"];
            decimal gbp = model.Rates["GBP"];
            decimal ron = model.Rates["RON"];
            decimal eur = model.Rates["EUR"];

            //dynamic valueForConversion = ValueForConversion;

            //string fromCurrency = FromCurrency;

            //string toCurrency = ToCurrency;

            model.ValueAfterConversion = currencyConversion.ConverseCurrency(model.FromCurrency, model.ToCurrency, (decimal) model.ValueForConversion, czk, gbp, ron, eur);

            ViewData["myModel"] = model;

            return View(model);
        }

    }
}