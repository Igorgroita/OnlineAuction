using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Models
{
    public class PhotoPath : BaseEntity
    {
        public long LotId { get; set; }
        public Lot Lot { get; set; }
        public string Path { get; set; }
    }
}
