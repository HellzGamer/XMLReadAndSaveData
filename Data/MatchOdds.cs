using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "MatchOdds")]
    public class MatchOdds
    {
        [XmlElement(ElementName = "Bet")]
        public List<Bet> Bet { get; set; }
    }
}
