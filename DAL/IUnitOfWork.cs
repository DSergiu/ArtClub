namespace DAL
{
    using System;
    using Domain;

    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Member> MemberRepository { get; }
        IGenericRepository<Artitem> ArtitemRepository { get; }
        IGenericRepository<Auction> AuctionRepository { get; }


        void Save();
    }
}
