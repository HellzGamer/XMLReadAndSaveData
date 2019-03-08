using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Texts")]
    public class Texts
    {
        [XmlElement(ElementName = "Text")]
        public List<Text> Text { get; set; }
    }
}
