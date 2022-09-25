using System.Collections.Generic; 
using System; 
namespace MegaMill.Models{ 

    public class CurrentNumbersResponse
    {
        public Drawing Drawing { get; set; }
        public Jackpot Jackpot { get; set; }
        public List<PrizeTier> PrizeTiers { get; set; }
        public MatchWinners MatchWinners { get; set; }
        public PrizeMatrix PrizeMatrix { get; set; }
        public DateTime NextDrawingDate { get; set; }
    }

}