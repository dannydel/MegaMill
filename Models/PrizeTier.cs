using System;
using System.Text.Json.Serialization;

namespace MegaMill.Models{ 

    public class PrizeTier
    {
        public DateTime? PlayDate { get; set; }
        public int Tier { get; set; }
        public bool IsMegaplier { get; set; }
        public int Winners { get; set; }
        public int MatrixRowId { get; set; }
        public int MatrixID { get; set; }
        [JsonPropertyName("prizeTier")]
        public int PrizeTierNumber { get; set; }
        public int TierWhiteBall { get; set; }
        public bool TierMegaBall { get; set; }
        public bool IsJackpot { get; set; }
        public double PrizeAmount { get; set; }
        public double Mega2 { get; set; }
        public double Mega3 { get; set; }
        public double Mega4 { get; set; }
        public double Mega5 { get; set; }
        public double Odds { get; set; }
    }

}