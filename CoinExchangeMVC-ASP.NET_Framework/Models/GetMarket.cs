using System.Collections.Generic;

namespace CoinExchangeMVC_ASP.NET_Framework.Models
{
    public class GetMarket
    {
        public int success;
        public string request;
        public string message;
        public List<Market> result;
    }
}