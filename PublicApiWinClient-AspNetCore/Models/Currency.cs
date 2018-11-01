using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace PublicApi_AspNetCore_Client.Models
{
    class Currency
    {
        public Object getCurrencyFromFixerIo()
        {
            string appid = "82317600e69a22e0938a30092fbfa178";
            string url = "http://data.fixer.io/api/latest?access_key=" + appid;
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}
