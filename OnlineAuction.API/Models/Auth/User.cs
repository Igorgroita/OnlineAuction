using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace OnlineAuction.Domain.Auth
{
    public class User : IdentityUser<long>
    {
        public int AccountBalance { get; set; }


    }
}
