using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Domain;


namespace DAL
{
    public class AuctionItemMap : EntityTypeConfiguration<AuctionItem>
    {
        public AuctionItemMap()
        {
            // Primary Key
            HasKey(t => new { t.AuctionId, t.ItemId });

            // Properties
            Property(t => t.AuctionId).IsRequired();
            Property(t => t.ItemId).IsRequired();

            // Table & Column Mappings
            ToTable("AuctionItems");
            Property(t => t.AuctionId).HasColumnName("AuctionId");
            Property(t => t.ItemId).HasColumnName("ItemId");

            HasRequired(t => t.Auction).WithMany(t => t.AuctionItems).HasForeignKey(d => d.AuctionId);
        }
    }
}
