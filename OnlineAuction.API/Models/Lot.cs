using OnlineAuction.Domain.Auth;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAuction.Domain.Models
{
    public class Lot : BaseEntity
    {
        public User AuctioneerId { get; set; }
        public User BuyerId { get; set; }
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
        public decimal CurrentPrice { get; set; }
        public string PhotoFilePath { get; set; }
        public DateTime StartNegotiationTime { get; set; }
        public DateTime SellTime { get; set; }
    }
}
