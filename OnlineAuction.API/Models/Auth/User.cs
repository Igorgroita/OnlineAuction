using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace OnlineAuction.Domain.Auth
{
    public class User : IdentityUser<int>
    {
        public int AccountBalance { get; set; }
    }
}
