using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Odds")]
    public class Odds
    {
        [XmlAttribute(AttributeName = "OutCome")]
        public string OutCome { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlAttribute(AttributeName = "SpecialBetValue")]
        public string SpecialBetValue { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
    }
}
