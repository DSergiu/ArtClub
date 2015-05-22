using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Controlller.Interfaces
{
    public interface IArtitemCtrl
    {
        Artitem GetArtitemById(int artitemId);
        Artitem GetArtitemByIdKey(int artitemidKey);
        ICollection<Artitem> GetAllArtitems();

        int CreateArtitem(Artitem artitem);
        void UpdateArtitem(Artitem artitem);

        void DeleteArtitem(Artitem artitem);
    }
}
