using System.Collections.Generic; 
using System; 
namespace MegaMill.Models{ 

    public class PrizeMatrix
    {
        public int MatrixID { get; set; }
        public DateTime? MatrixStart { get; set; }
        public DateTime? MatrixEnd { get; set; }
        public int WhiteBallMax { get; set; }
        public int MegaBallMax { get; set; }
        public bool MatrixCurrent { get; set; }
        public int TicketPrice { get; set; }
        public string? FooterText { get; set; }
        public List<PrizeTier>? PrizeTiers { get; set; }
    }

}