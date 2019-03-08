using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Sports")]
    public class Sports
    {
        [XmlElement(ElementName = "Sport")]
        public List<Sport> Sport { get; set; }
    }
}
