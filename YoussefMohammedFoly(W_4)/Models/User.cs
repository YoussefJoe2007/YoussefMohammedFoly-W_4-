using Microsoft.AspNetCore.Identity;

namespace YoussefMohammedFoly_W_4_.Models
{

        public class User : IdentityUser
        {
            public string FullName { get; set; }
        }
}

