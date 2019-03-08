using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Category")]
    public class Category
    {
        [XmlElement(ElementName = "Texts")]
        public Texts Texts { get; set; }
        [XmlElement(ElementName = "Tournament")]
        public Tournament Tournament { get; set; }
        [XmlAttribute(AttributeName = "BetradarCategoryID")]
        public string BetradarCategoryID { get; set; }
        [XmlElement(ElementName = "Outright")]
        public List<Outright> Outright { get; set; }
    }
}
