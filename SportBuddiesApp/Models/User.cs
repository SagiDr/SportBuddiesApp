using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBuddiesApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Gender { get; set; }

        public string? IsAdmin { get; set; }

        public string? ProfileImageExtention { get; set; }

        public int? FavoriteSport { get; set; }

        public User() { }
    }
}
