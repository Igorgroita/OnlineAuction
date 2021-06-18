using OnlineAuction.API.Models;
using OnlineAuction.API.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAuction.API.Models
{
    public class Lot : BaseEntity
    {
        public long AuctioneerId { get; set; }
        public string LotName { get; set; }
        public string Description { get; set; }
        public IList<Bet> Bets { get; set; }
        public IList<LotCathegory> LotCathegories { get; set; }
        public IList<PhotoPath> PhotoPaths { get; set; }
        public IList<Question> Questions { get; set; }
    }
}
