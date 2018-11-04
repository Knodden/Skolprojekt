using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSSreader.BusinessLayer
{
    public class Episode
    {
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("pubDate")]
        public string PubDate { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
