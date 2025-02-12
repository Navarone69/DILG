using Microsoft.AspNetCore.Identity;

namespace DILG.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
