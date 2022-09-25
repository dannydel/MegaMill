using System; 
namespace MegaMill.Models{ 

    public class Drawing
    {
        public DateTime PlayDate { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public int N4 { get; set; }
        public int N5 { get; set; }
        public int MBall { get; set; }
        public int Megaplier { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
        public long PlayDateTicks { get; set; }
        public DateTime IgnoreServiceUntil { get; set; }
    }

}