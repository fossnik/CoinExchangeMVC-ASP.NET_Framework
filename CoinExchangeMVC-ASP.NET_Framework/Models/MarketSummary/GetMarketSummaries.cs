﻿using System.Collections.Generic;

namespace CoinExchangeMVC_ASP.NET_Framework.Models.MarketSummary
{
    public class GetMarketSummaries
    {
        public int success;
        public string request;
        public string message;
        public List<MarketSummary> result;
    }
}