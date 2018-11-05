using RSSreader.BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSSreader.DataAcessLayer
{
    class XML
    {
        public void WriteCategories(List<Category> categories, Stream stream)
        {
            var writer = new XmlSerializer(typeof(List<Category>));
            writer.Serialize(stream, categories);
        }

        public void WritePodcasts(List<Podcast> podcasts, Stream stream)
        {
            var writer = new XmlSerializer(typeof(List<Podcast>));
            writer.Serialize(stream, podcasts);
        }

        public List<Category> ReadCategories(Stream stream)
        {
            var reader = new XmlSerializer(typeof(List<Category>));
            var data = reader.Deserialize(stream);
            var conv = (List<Category>)data;
            return conv;
        }

        public List<Podcast> ReadPodcasts(Stream stream)
        {
            var reader = new XmlSerializer(typeof(List<Podcast>));
            var data = reader.Deserialize(stream);
            var conv = (List<Podcast>)data;
            return conv;
        }
        public List<Episode> XmlToEpisode(String content)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(rss));
            using (StringReader reader = new StringReader(content))
            {
                var root = (rss)(serializer.Deserialize(reader));

                return root.channel.Items;
            }
        }
    }
    public class rss
    {
        public channel channel { get; set; }
    }
    public class channel
    {
        [XmlElement("item")]
        public List<Episode> Items { get; set; }
    }
}
