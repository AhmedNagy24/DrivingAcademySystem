
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Models
{
    public abstract class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public virtual List<RefreshToken>? RefreshTokens { get; set; }
    }
}