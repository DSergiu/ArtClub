using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AuctionItem
    {
        public int AuctionId { get; set; }
        public int ItemId { get; set; }

        public Auction Auction { get; set; }
        public Artitem Item { get; set; }

        public AuctionItem setAuction(int auctionId)
        {
            this.AuctionId = auctionId;
            return this;
        }
        public AuctionItem setItemId(int itemId)
        {
            this.ItemId = itemId;
            return this;
        }
    }
} 