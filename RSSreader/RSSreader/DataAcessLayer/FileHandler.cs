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

    interface ICreateDirectory
    {
        string CreateCatDirectory();
        string CreatePodDirectory();
    }

    class FileHandler : ICreateDirectory
    {
        public string CreateCatDirectory()
        {
            var dir = @".\RSSreader\RSSreader\DataAcessLayer\XMLFiles\"; 
            var filePath1 = dir + "\\Category.xml";
            if(!Directory.Exists(dir)) 
            {
                Directory.CreateDirectory(dir);
            }
            return filePath1;
        }

        public string CreatePodDirectory()
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
            string path = CreatePodDirectory();
            using (var fs = new FileStream(path, FileMode.Create))
            {
                new XML().WritePodcasts(podcasts, fs);
            }
        }

        public List<Podcast> LoadPodcasts()
        {
            var path = CreatePodDirectory();
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
        public void SaveCategories(List<Category> categories)
        {
            string path = CreateCatDirectory();
            using (var fs = new FileStream(path, FileMode.Create))
            {
                new XML().WriteCategories(categories, fs);
            }
        }
        public List<Category> LoadCategories()
        {
            var path = CreateCatDirectory();
            if (File.Exists(path))
            {
                using (var fs = new FileStream(path, FileMode.Open))
                {
                    var catList = new XML().ReadCategories(fs);
                    return catList;
                }
            }
            else
            {
                return new List<Category>();
            }
        }
    }
}
