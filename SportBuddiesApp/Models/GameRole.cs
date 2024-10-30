using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBuddiesApp.Models
{
    public class GameRole
    {
        public int RoleId { get; set; }

        public int? GameTypeId { get; set; }

        public string? Name { get; set; }

        public int? PositionX { get; set; }

        public int? PositionY { get; set; }

        public GameRole() { }

       

        //// Optionally, include a collection of GameUser IDs if needed
        //public ICollection<int>? GameUserIds { get; set; } = new List<int>();
    }
}
