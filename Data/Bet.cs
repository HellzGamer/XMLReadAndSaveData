﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewXmlWork.Data
{
    [XmlRoot(ElementName = "Bet")]
    public class Bet
    {
        [XmlElement(ElementName = "Odds")]
        public List<Odds> Odds { get; set; }
        [XmlAttribute(AttributeName = "OddsType")]
        public string OddsType { get; set; }
    }
}
