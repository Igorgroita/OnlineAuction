using System.ComponentModel.DataAnnotations;

namespace OnlineAuction.API.Dtos.Account
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
