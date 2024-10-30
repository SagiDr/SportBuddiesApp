using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBuddiesApp.Models
{
    public class GameUser
    {
        public int GameId { get; set; }

        public int RoleId { get; set; }

        public int UserId { get; set; }

        public GameUser() { }

    }
}
