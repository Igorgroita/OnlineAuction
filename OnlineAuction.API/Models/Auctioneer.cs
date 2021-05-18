using OnlineAuction.Domain.Auth;
using System.Collections.Generic;

namespace OnlineAuction.Domain.Models
{
    class Auctioneer : User
    {
        public int Rating { get; set; }

        public List<Lot> Lots { get; set; }
    }
}
