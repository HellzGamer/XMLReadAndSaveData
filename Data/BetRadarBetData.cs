using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "BetradarBetData")]
    public class BetradarBetData
    {
        [XmlElement(ElementName = "Timestamp")]
        public TimeStamp Timestamp { get; set; }
        [XmlElement(ElementName = "Sports")]
        public Sports Sports { get; set; }
    }
}
