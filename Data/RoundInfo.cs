using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "RoundInfo")]
    public class RoundInfo
    {
        [XmlElement(ElementName = "Round")]
        public string Round { get; set; }
        [XmlElement(ElementName = "Cupround")]
        public string Cupround { get; set; }
        [XmlElement(ElementName = "ID")]
        public string ID { get; set; }
    }
}
