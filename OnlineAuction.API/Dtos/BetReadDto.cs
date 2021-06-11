using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Dtos
{
    public class BetReadDto
    {
        public long LotId { get; set; }
        public long BetterId { get; set; }
        public decimal BetSize { get; set; }
    }
}
