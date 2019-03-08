using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "EventName")]
    public class EventName
    {
        [XmlElement(ElementName = "Texts")]
        public Texts Texts { get; set; }
    }
}
