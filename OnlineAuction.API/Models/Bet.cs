using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Models
{
    public class Bet : BaseEntity
    {
        public Lot Lot { get; set; }
        public int LotId { get; set; }
        public int BetterId { get; set; }
        public decimal BetSize { get; set; }
    }
}
