using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBuddiesApp.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string? ImageUrl { get; set; }

        public string? Description { get; set; }

        public int? GameId { get; set; }

        public Photo() { }
    }
}
