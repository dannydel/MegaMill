using System; 
namespace MegaMill.Models{ 

    public class Jackpot
    {
        public DateTime? PlayDate { get; set; }
        public double CurrentPrizePool { get; set; }
        public double NextPrizePool { get; set; }
        public double CurrentCashValue { get; set; }
        public double NextCashValue { get; set; }
        public int Winners { get; set; }
        public bool Verified { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }

}