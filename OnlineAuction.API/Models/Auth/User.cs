using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace OnlineAuction.API.Auth
{
    public class User : IdentityUser<long>
    {
        public int AccountBalance { get; set; }


    }
}
