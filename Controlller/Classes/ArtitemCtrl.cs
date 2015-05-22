namespace Controlller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Controlller.Interfaces;
    using DAL;
    using Domain;
    using System.IO;
    
    public class ArtitemCtrl : IArtitemCtrl
    {
        public int CreateArtitem(Artitem artitem)
        {
            using (var uow = new EFUnitOfWork()) 
            {
                if (artitem.IdKey != 0)
                {
                    if (artitem.IdKey >= 1000 && artitem.IdKey <= 9999)
                    {
                        Artitem art = uow.ArtitemRepository.GetArtitemByIdKey(artitem.IdKey, 0);
                        if (art != null)
                            throw new SameArtItemIdException();
                        else
                        {
                            try
                            {
                                uow.ArtitemRepository.CreateArtitem(artitem);
                                uow.Save();
                                return artitem.Id;
                            }
                            catch (Exception) { }
                        }
                    }
                    else
                    {
                        throw new ArtItemNotInRangeException();
                    }
                }

                Random rand = new Random();

                while(true)
                {
                    int rand_id = 1000 + rand.Next(8999);
                    artitem.IdKey = rand_id;

                    try {
                        uow.ArtitemRepository.CreateArtitem(artitem);
                        uow.Save();
                        return artitem.Id;
                    }
                    catch(Exception) {}
                }                
            }
        }


        public Artitem GetArtitemByIdKey(int artitemidKey)
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.ArtitemRepository.GetArtitemByIdKey(artitemidKey, -1);
            }
        }

        public ICollection<Artitem> GetAllArtitems()
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.ArtitemRepository.GetAllArtitems().ToArray();
            }
        }

        public void UpdateArtitem(Artitem artitem) 
        {
            using (var uow = new EFUnitOfWork()) 
            {
               if (artitem.IdKey >= 1000 && artitem.IdKey <= 9999)
               {
                   Artitem art = uow.ArtitemRepository.GetArtitemByIdKey(artitem.IdKey, artitem.Id);
                   if (art != null)
                       throw new SameArtItemIdException();
               }
               
               uow.ArtitemRepository.Update(artitem);
               uow.Save();
            }
        }

        public void DeleteArtitem(Artitem artitem) 
        {
            using (var uow = new EFUnitOfWork()) 
            {
                uow.ArtitemRepository.Delete(artitem);
                uow.Save();
            }
        }

        public Artitem GetArtitemById(int artitemId) 
        {
            using (var uow = new EFUnitOfWork()) 
            {
                return uow.ArtitemRepository.GetByID(artitemId);
            }
        }
    }
}
