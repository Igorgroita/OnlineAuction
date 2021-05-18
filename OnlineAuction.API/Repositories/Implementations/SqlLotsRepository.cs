using OnlineAuction.API.Repositories.Interfaces;
using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Repositories.Implementations
{
    public class SqlLotsRepository : ILotsRepository
    {
        private readonly OnlineAuctionDbContext _context;


        public SqlLotsRepository(OnlineAuctionDbContext context)
        {
            _context = context;
        }

        public void CreateLot(Lot lot)
        {
            if (lot == null) {
                throw new ArgumentNullException(nameof(lot));

            }
            _context.Lots.Add(lot);
        }

        public void DeleteLot(Lot lot)
        {
            if (lot == null)
            {
                throw new ArgumentNullException(nameof(lot));
            }
            _context.Lots.Remove(lot);
        }


        public IEnumerable<Lot> GetAllLots()
        {
            return _context.Lots.ToList();            
        }

        public Lot GetLotById(int id)
        {
            return _context.Lots.FirstOrDefault(lot => lot.Id == id);    
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateLot(int id)
        {
           
        }
    }
}
