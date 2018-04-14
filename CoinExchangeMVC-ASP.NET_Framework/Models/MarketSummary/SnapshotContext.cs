using System.Data.Entity;

namespace CoinExchangeMVC_ASP.NET_Framework.Models.MarketSummary
{
    public class SnapshotContext : DbContext
    {
        public DbSet<Snapshot> Snapshots { get; set; }
        public DbSet<MarketSummary> MarketSummaries { get; set; }
    }
}