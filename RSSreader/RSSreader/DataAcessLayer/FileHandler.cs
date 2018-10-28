using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace RSSreader.DataAcessLayer
{
    class FileHandler
    {
        
        
        public static bool Exists ()
        {
            var dir = @"C:\Users\Dator\source\repos\Skolprojekt\RSSreader\RSSreader\DataAcessLayer\XMLFiles\";
            var filePath1 = dir + "\\Category.xml";
            var filePath2 = dir + "\\Podcast.xml";
            if(!Dictionary.Exists(dir)) 
            {
                Dictionary.CreateDirectory(dir);
            }
            if(!File.Exists(filePath1 || filePath2)) 
            {
                File.Create(filePath1 || filePath2);
            }
        }
        
    }
}
