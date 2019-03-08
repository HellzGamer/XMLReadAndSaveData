using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewXmlWork.Model
{
    public class Markets
    {
        public int MarketID { get; set; }
        public string MarketOutcome { get; set; }
        public decimal MarketOdds { get; set; }
        public int BetType { get; set; }
    }
}
