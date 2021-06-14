using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Models
{
    public class Question : BaseEntity
    {
        public long LotId { get; set; }
        public Lot Lot { get; set; }
        public long UserId { get; set; }
        public long Formulation { get; set; }
        public long ResponseId { get; set; }
        public Response Response { get; set; }
    }
}
