using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Competitors")]
    public class Competitors
    {
        [XmlElement(ElementName = "Texts")]
        public List<Texts> Texts { get; set; }
    }
}
