using System; 
namespace MegaMill.Models{ 

    public class MatchWinners
    {
        public DateTime? PlayDate { get; set; }
        public string? WinnerText { get; set; }
        public string? RawText { get; set; }
        public bool ManualEntry { get; set; }
    }

}