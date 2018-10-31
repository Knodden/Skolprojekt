using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using RSSreader.BusinessLayer;


namespace RSSreader.DataAcessLayer
{
    class FileHandler
    {
        public void Exists ()
        {
            var dir = @".\RSSreader\RSSreader\DataAcessLayer\XMLFiles\"; 
            var filePath1 = dir + "\\Category.xml";
            if(!Directory.Exists(dir)) 
            {
                Directory.CreateDirectory(dir);
            }
            if(!File.Exists(filePath1)) 
            {
                File.Create(filePath1);
            }
        }

        public string Exists2()
        {
            var dir = @".\RSSreader\RSSreader\DataAcessLayer\XMLFiles\";
            var filePath2 = dir + "\\Podcast.xml";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return filePath2;
        }

        public void SavePodcasts(List<Podcast> podcasts)
        {
            string path = Exists2();
            using (var fs = new FileStream(path, FileMode.Create))
            {
                new XML().WritePodcasts(podcasts, fs);
            }
        }

        public List<Podcast> LoadPodcasts()
        {
            var path = Exists2();
            if (File.Exists(path))
            {
                using(var fs = new FileStream(path, FileMode.Open))
                {
                   var podList = new XML().ReadPodcasts(fs);
                    return podList;
                }
            }
            else
            {
                return new List<Podcast>();
            }
        }
    }
}
//var dir = @"C:\Users\Dator\source\repos\Skolprojekt\RSSreader\RSSreader\DataAcessLayer\XMLFiles\";