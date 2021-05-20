using OnlineAuction.API.Models;
using OnlineAuction.Domain.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAuction.Domain.Models
{
    public class Lot : BaseEntity
    {
        public int AuctioneerId { get; set; }
        public int? BuyerId { get; set; }
        public string LotName { get; set; }
        public string Description { get; set; }
        public bool Active 
        {
            get
            {
                return Active;
            }
            set 
            {
                DateTime now = DateTime.Now;
                Active = StartNegotiationTime < now && now < SellTime; 
            }
        }

        public decimal? MinimalBet { get; set; }
        public decimal? CurrentPrice { get; set; }
        public string PhotoFilePath { get; set; }
        public DateTime StartNegotiationTime { get; set; }
        public DateTime SellTime { get; set; }

        public List<Bet> Bets { get; set; }
    }
}
