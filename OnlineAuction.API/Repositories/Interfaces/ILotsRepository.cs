using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Repositories.Interfaces
{
    public interface ILotsRepository 
    {
        IEnumerable<Lot> GetAllLots();

        void CreateLot(Lot lot);

        Lot GetLotById(int id);

        void UpdateLot(int id);

        void DeleteLot(Lot lot);

        bool SaveChanges();
    }
}
