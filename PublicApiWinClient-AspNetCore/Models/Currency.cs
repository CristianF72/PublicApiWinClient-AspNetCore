using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using PublicApi_AspNetCore_Client.Controllers;

namespace PublicApi_AspNetCore_Client.Models
{
    public class Currency : IDisposable
    {
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
        public decimal ValueAfterConversion { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
