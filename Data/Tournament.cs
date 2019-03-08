using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Tournament")]
    public class Tournament
    {
        [XmlElement(ElementName = "Texts")]
        public Texts Texts { get; set; }
        [XmlElement(ElementName = "Match")]
        public List<Match> Match { get; set; }
        [XmlAttribute(AttributeName = "BetradarTournamentID")]
        public string BetradarTournamentID { get; set; }
    }
}
