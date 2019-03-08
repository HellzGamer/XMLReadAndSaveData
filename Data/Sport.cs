using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Sport")]
    public class Sport
    {
        //public string SportName { get; set; }
        [XmlElement(ElementName = "Texts")]
        public Texts Texts { get; set; }
        [XmlElement(ElementName = "Category")]
        public List<Category> Category { get; set; }
        [XmlAttribute(AttributeName = "BetradarSportID")]
        public string BetradarSportID { get; set; }
    }
}
