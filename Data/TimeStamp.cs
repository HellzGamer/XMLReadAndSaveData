using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Timestamp")]
    public class TimeStamp
    {
        [XmlAttribute(AttributeName = "CreatedTime")]
        public string CreatedTime { get; set; }
        [XmlAttribute(AttributeName = "TimeZone")]
        public string TimeZone { get; set; }
    }
}
