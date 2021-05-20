using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Dtos
{
    public class LotCreateDto
    {
        [Required]
        [MaxLength(200)]
        public string LotName { get; set; }

        [Required]
        public int AuctioneerId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        
    }
}
