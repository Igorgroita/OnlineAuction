using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Models
{
    public class Bet : BaseEntity
    {
        public long LotId { get; set; }
        public long BetterId { get; set; }
        public decimal BetSize { get; set; }
    }
}
