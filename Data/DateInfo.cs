using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "DateInfo")]
    public class DateInfo
    {
        [XmlElement(ElementName = "MatchDate")]
        public string MatchDate { get; set; }
    }
}
