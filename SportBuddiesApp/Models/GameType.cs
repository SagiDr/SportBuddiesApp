using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBuddiesApp.Models
{
    public class GameType
    {
        public int IdType { get; set; }

        public string? Name { get; set; }

        public string? IconExtention { get; set; }

        public string? CourtExtention { get; set; }

        public GameType() { }


        //// Optionally, include collections if needed for specific operations
        //public ICollection<int>? GameDetailIds { get; set; } = new List<int>();
        //public ICollection<int>? GameRoleIds { get; set; } = new List<int>();
        //public ICollection<int>? UserIds { get; set; } = new List<int>();
    }
}
