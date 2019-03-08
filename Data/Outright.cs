using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Outright")]
    public class Outright
    {
        [XmlElement(ElementName = "Fixture")]
        public Fixture Fixture { get; set; }
        [XmlAttribute(AttributeName = "BetradarOutrightID")]
        public string BetradarOutrightID { get; set; }
        [XmlElement(ElementName = "OutrightOdds")]
        public OutrightOdds OutrightOdds { get; set; }
    }
}
