using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Domain;


namespace DAL
{
    public class AuctionMap : EntityTypeConfiguration<Auction>
    {
        public AuctionMap()
        {
            HasKey(t => t.Id);

            Property(t => t.StartDate).IsRequired();
            Property(t => t.EndDate).IsRequired();

            ToTable("Auctions");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.StartDate).HasColumnName("StartDate");
            Property(t => t.EndDate).HasColumnName("EndDate");
            Property(t => t.CreatedById).HasColumnName("CreatedById");            
        }
    }
}
