namespace DAL
{
    using System.Data.Entity;
    using Domain;

    public class ArtclubContext : DbContext
    {
        public ArtclubContext() : base("Name=ArtclubContextLocal")
        {
            Configuration.LazyLoadingEnabled = false;   // disable lazy loading (enable eager loading :D)
            Configuration.ProxyCreationEnabled = false; // disble proxy creation
            //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);  // Uncomment to see SQL queries in Output area
        }

        #region DbSets

        public DbSet<Member> Members { get; set; }
        public DbSet<Artitem> Artitems { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<AuctionItem> AuctionItems { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new ArtitemMap());
            modelBuilder.Configurations.Add(new AuctionMap());
            modelBuilder.Configurations.Add(new AuctionItemMap());
        }
    }
}