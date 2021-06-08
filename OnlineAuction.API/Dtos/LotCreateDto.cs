using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Dtos
{
    public class LotCreateDto
    {
        public long Id { get; set; }
        public string LotName { get; set; }
        public int AuctioneerId { get; set; }
        public string Description { get; set; }
        
    }
}
