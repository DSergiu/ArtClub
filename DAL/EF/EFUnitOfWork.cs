namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Validation;

    using Domain;


    public class EFUnitOfWork : IUnitOfWork
    {
        public EFUnitOfWork() : this(new ArtclubContext()) { }

        public EFUnitOfWork(ArtclubContext context)
        {
            Context = context;
        }

        public ArtclubContext Context { get; private set; }


        #region IDisposable && Dispose(bool)

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);  // GarbageCollector, do not bother to check me!
        }


        private bool _disposed;

        private void Dispose(bool disposing)
        {
            if (Context != null && !_disposed && disposing)
            {
                Context.Dispose();
            }

            _disposed = true;
        }

        #endregion

        #region IUnitOfWork members EFGenericRepository<T>

        private EFGenericRepository<Member> _memberRepository;
        private EFGenericRepository<Artitem> _artitemRepository;
        private EFGenericRepository<Auction> _auctionRepository;

        public IGenericRepository<Member> MemberRepository
        {
            get
            {
                _memberRepository = _memberRepository ?? new EFGenericRepository<Member>(Context);
                return _memberRepository;
            }
        }

        public IGenericRepository<Artitem> ArtitemRepository
        {
            get
            {
                _artitemRepository = _artitemRepository ?? new EFGenericRepository<Artitem>(Context);
                return _artitemRepository;
            }
        }
       
        public IGenericRepository<Auction> AuctionRepository
            {
            get
                {
                _auctionRepository = _auctionRepository ?? new EFGenericRepository<Auction>(Context);
                return _auctionRepository;
                }
            }

        #endregion

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
