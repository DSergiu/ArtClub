namespace Domain
{
    using System;
    using System.Collections.Generic;
 
    

    public class Auction
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedById { get; set; }
        public Member CreatedBy { get; set; }
        public ICollection<AuctionItem> AuctionItems { get; set; }

        public Auction SetStartDate(DateTime StartDate)
        {
            this.StartDate = StartDate;
            return this;
        }

        public Auction SetEndDate(DateTime EndDate)
        {
            this.EndDate = EndDate;
            return this;
        }

        public Auction SetCreatedBy(int memberId)
        {
            this.CreatedById = memberId;
            return this;
        }

        public Auction AddArtitem(int artitemId)
        {
            AuctionItem auctionItem = new AuctionItem().setAuction(this.Id).setItemId(artitemId);
            AuctionItems.Add(auctionItem);

            return this;
        }
    }
}