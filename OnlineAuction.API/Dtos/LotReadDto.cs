using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Dtos
{
    public class LotReadDto
    {
        public string LotName { get; set; }
        public long AuctioneerId { get; set; }
        public string Description { get; set; }
    }
}
