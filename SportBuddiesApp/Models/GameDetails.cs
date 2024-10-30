using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBuddiesApp.Models
{
    public class GameDetails
    {
        public int GameId { get; set; }

        public string? GameName { get; set; }

        public DateOnly? Date { get; set; }

        public TimeOnly? Time { get; set; }

        public string? Location { get; set; }

        public int? GameType { get; set; }

        public string? State { get; set; }

        public string? Score { get; set; }

        public string? Notes { get; set; }

        public string? Competitive { get; set; }

        public string? Link { get; set; }

        public decimal? LocationLength { get; set; }

        public decimal? LocationWidth { get; set; }

        public int? CreatorId { get; set; }

        public GameDetails() { }

        
        //// Optionally include collections if needed for specific operations
        //    public ICollection<int>? GameUserIds { get; set; } = new List<int>();
        //    public ICollection<int>? PhotoIds { get; set; } = new List<int>();
        //}
    }
}
