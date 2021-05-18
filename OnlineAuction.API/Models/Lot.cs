using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAuction.Domain.Models
{
    public class Lot : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public bool Active { get; set; } = false;

        [Required]
        public decimal CurrentPrice { get; set; }



    }
}
