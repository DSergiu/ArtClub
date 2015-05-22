namespace Controlller.Interfaces
{
    using Domain;
    using System;
    using System.Collections.Generic;

    public interface IAuctionCtrl
    {
       
        int CreateAuction(Auction auction);
        Auction GetAuctionById(int auctionid);
        ICollection<Auction> GetAllAuctions();

        void UpdateAuction(Auction auction);
        void DeleteAuction(Auction auction);
        void AddArtToAuction(int auctionId, int artitemId);
    }
}
