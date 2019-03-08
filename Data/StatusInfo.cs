using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "StatusInfo")]
    public class StatusInfo
    {
        [XmlElement(ElementName = "Off")]
        public string Off { get; set; }
    }
}
