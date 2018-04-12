﻿using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Mvc;
using CoinExchangeMVC_ASP.NET_Framework.Models;
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

            GetMarketResult getMarketResult = null;

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

                    getMarketResult = JsonConvert.DeserializeObject<GetMarketResult>(content);
                }
            }

            if (getMarketResult != null)
                return View(getMarketResult);
            else
                return HttpNotFound();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}