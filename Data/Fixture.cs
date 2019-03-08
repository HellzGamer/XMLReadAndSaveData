using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Fixture")]
    public class Fixture
    {
        [XmlElement(ElementName = "Competitors")]
        public Competitors Competitors { get; set; }
        [XmlElement(ElementName = "DateInfo")]
        public DateInfo DateInfo { get; set; }
        [XmlElement(ElementName = "StatusInfo")]
        public StatusInfo StatusInfo { get; set; }
        [XmlElement(ElementName = "NeutralGround")]
        public string NeutralGround { get; set; }
        [XmlElement(ElementName = "RoundInfo")]
        public RoundInfo RoundInfo { get; set; }
        [XmlElement(ElementName = "NumberOfSets")]
        public string NumberOfSets { get; set; }
        [XmlElement(ElementName = "EventInfo")]
        public EventInfo EventInfo { get; set; }
    }
}
