using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public static class AuctionRepoExtension
    {
        public static void CreateAuction(this IGenericRepository<Auction> _auctionRepo, Auction auction)
        {
            _auctionRepo.Insert(auction);
        }

        public static Auction GetAuction(this IGenericRepository<Auction> _auctionRepo, int auctionid)
        {
            return _auctionRepo.Find(a => a.Id.Equals(auctionid)).FirstOrDefault();
        }
        public static IQueryable<Auction> GetAllAuctions(this IGenericRepository<Auction> _auctionRepo)
        {
            return _auctionRepo.Find(a => true);
        }
    }
}
