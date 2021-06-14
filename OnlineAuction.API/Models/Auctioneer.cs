using OnlineAuction.API.Auth;
using System.Collections.Generic;

namespace OnlineAuction.API.Models
{
    class Auctioneer : User
    {
        public int Rating { get; set; }

        public List<Lot> Lots { get; set; }
    }
}
