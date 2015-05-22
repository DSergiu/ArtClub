using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;
using Controlller.Interfaces;


namespace Controlller.Classes
{
    public class AuctionCtrl : IAuctionCtrl
    {
        public int CreateAuction(Auction auction)
        {
            using (var uow = new EFUnitOfWork())
            {
                Auction auction1 = uow.AuctionRepository.GetAuction(auction.Id);
                if (auction1 != null)
                    throw new SameAuctionIdException();

                uow.AuctionRepository.CreateAuction(auction);
                uow.Save();
                return auction.Id;
            }
        }

        public ICollection<Auction> GetAllAuctions()
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.AuctionRepository.GetAllAuctions().ToArray();
            }
       }

        public void UpdateAuction(Auction auction)
        {
            using (var uow = new EFUnitOfWork())
                {
                uow.AuctionRepository.Update(auction);
                uow.Save();
                }
        }

        public void DeleteAuction(Auction auction)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.AuctionRepository.Delete(auction);
                uow.Save();
            }
        }

         public Auction GetAuctionById(int auctionid) 
         {
            using (var uow = new EFUnitOfWork()) 
            {
                return uow.AuctionRepository.GetByID(auctionid);
            }
        }

        public void AddArtToAuction(int auctionId, int artitemId)
        {
                using (var uow = new EFUnitOfWork())
                {
                    Auction auction = uow.AuctionRepository.GetAuction(auctionId);
                    Artitem artitem = uow.ArtitemRepository.GetArtitem(artitemId);

                    if (auction == null)
                        throw new NonExistingAuctionException();
                    if (artitem == null)
                        throw new NonExistingArtitemException();


                    auction.AddArtitem(artitemId);
                    uow.Save();
                }
        }
    }
}
    
