using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Models
{
    public class LotCathegory
    {
        public long LotId { get; set; }
        public Lot Lot { get; set; }

        public long CathegoryId { get; set; }
        public Cathegory Cathegory { get; set; }
    }
}
