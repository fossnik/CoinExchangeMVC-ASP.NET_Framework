using CoinExchangeMVC_ASP.NET_Framework.Models.MarketSummary;

namespace CoinExchangeMVC_ASP.NET_Framework.Models.Market
{
    public class Market
    {
        public int MarketID;
        public string MarketAssetName;
        public string MarketAssetCode;
        public int MarketAssetID;
        public string MarketAssetType;
        public string BaseCurrency;
        public string BaseCurrencyCode;
        public int BaseCurrencyID;
        public bool Active;

        public virtual Snapshot Snapshot { get; set; }
    }
}