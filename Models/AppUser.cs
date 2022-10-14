using Microsoft.AspNetCore.Identity;

namespace CalProTein.Models
{
        public class AppUser : IdentityUser
        {
                public string Occupation { get; set; }
        }
}
