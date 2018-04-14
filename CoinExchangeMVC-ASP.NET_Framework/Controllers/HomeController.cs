using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Mvc;
using CoinExchangeMVC_ASP.NET_Framework.Models;
using CoinExchangeMVC_ASP.NET_Framework.Models.Market;
using CoinExchangeMVC_ASP.NET_Framework.Models.MarketSummary;
using Newtonsoft.Json;

namespace CoinExchangeMVC_ASP.NET_Framework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMarket()
        {
            ViewBag.Message = "GetMarket Endpoint";

            GetMarket getMarketResult = null;

            string url = "https://www.coinexchange.io/api/v1/getmarkets";

            // web request
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";

            // response buffer
            WebResponse response = request.GetResponse();

            // response stream
            using (var responseStream = response.GetResponseStream())
            {
                // read stream
                using (var responseReader = new StreamReader(responseStream ?? throw new InvalidOperationException(), Encoding.UTF8))
                {
                    // string from stream
                    string content = responseReader.ReadToEnd();

                    getMarketResult = JsonConvert.DeserializeObject<GetMarket>(content);
                }
            }

            if (getMarketResult != null)
                return View(getMarketResult);
            else
                return HttpNotFound();
        }

        public ActionResult GetMarketSummaries()
        {
            ViewBag.Message = "Market Summaries";

            GetMarketSummaries getMarketSummariesResult = null;

            string url = "https://www.coinexchange.io/api/v1/getmarketsummaries";

            // web request
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";

            // response buffer
            WebResponse response = request.GetResponse();

            // response stream
            using (var responseStream = response.GetResponseStream())
            {
                // read stream
                using (var responseReader = new StreamReader(responseStream ?? throw new InvalidOperationException(), Encoding.UTF8))
                {
                    // string from stream
                    string content = responseReader.ReadToEnd();

                    getMarketSummariesResult = JsonConvert.DeserializeObject<GetMarketSummaries>(content);
                }
            }

            if (getMarketSummariesResult != null)
                return View(getMarketSummariesResult);
            else
                return HttpNotFound();
        }
    }
}