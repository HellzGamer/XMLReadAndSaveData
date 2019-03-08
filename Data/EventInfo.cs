using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "EventInfo")]
    public class EventInfo
    {
        [XmlElement(ElementName = "EventDate")]
        public string EventDate { get; set; }
        [XmlElement(ElementName = "EventName")]
        public EventName EventName { get; set; }
        [XmlElement(ElementName = "Off")]
        public string Off { get; set; }
        [XmlElement(ElementName = "TournamentId")]
        public string TournamentId { get; set; }
    }
}
