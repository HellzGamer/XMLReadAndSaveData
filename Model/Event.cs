using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewXmlWork.Model
{
    public class Event
    {
        public int EventID { get; set; }
        public int SportID { get; set; }
        public int TournamentID { get; set; }
        public string EventDate { get; set; }
        public int EventStatusInfo { get; set; }
        public int NeutralGround { get; set; }
        public int RoundInfo { get; set; }
    }
}
