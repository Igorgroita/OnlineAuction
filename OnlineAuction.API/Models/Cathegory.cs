using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Models
{
    public class Cathegory : BaseEntity
    {
        public string CathegoryName { get; set; }
    }
}
