using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public static class ArtitemRepoExtention
    {
        public static void CreateArtitem(this IGenericRepository<Artitem> _artitemRepo, Artitem artitem)
        {
            artitem.CreateAt = DateTime.UtcNow;
            _artitemRepo.Insert(artitem);
        }

        public static Artitem GetArtitem(this IGenericRepository<Artitem> _artitemRepo, int artitemid)
        {
            return _artitemRepo.Find(a => a.Id.Equals(artitemid)).FirstOrDefault();
        }

        public static Artitem GetArtitemByIdKey(this IGenericRepository<Artitem> _artitemRepo, int artitemidkey, int artitemId)
        {
            return _artitemRepo.Find(a => a.IdKey.Equals(artitemidkey) && !a.Id.Equals(artitemId)).FirstOrDefault();
        }
        

        public static IQueryable<Artitem> GetAllArtitems(this IGenericRepository<Artitem> _artitemRepo) {
            return _artitemRepo.Find(a => true);
        }

        
    }
}
