using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Match")]
    public class Match
    {
        [XmlElement(ElementName = "Fixture")]
        public Fixture Fixture { get; set; }
        [XmlElement(ElementName = "MatchOdds")]
        public MatchOdds MatchOdds { get; set; }
        [XmlAttribute(AttributeName = "BetradarMatchID")]
        public string BetradarMatchID { get; set; }
    }
}
