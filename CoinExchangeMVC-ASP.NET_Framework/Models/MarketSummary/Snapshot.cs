using System.Collections.Generic;

namespace CoinExchangeMVC_ASP.NET_Framework.Models.MarketSummary
{
    public class Snapshot
    {
        public int SnapId { get; set; }

        public virtual List<MarketSummary> MarketSummaries { get; set; }
    }
}