using RSSreader.DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RSSreader.BusinessLayer
{
    class FetchFeed
    {
        private HttpClient Client = new HttpClient();
        private async Task FetchFeeds(string[] feeds)
        {
            foreach(var f in feeds)
            {
                var content = await Client.GetStringAsync(f);
                //Anropa en metod
                var episodeList = new XML().XmlToEpisode(content);
                //Anropa en annan metod
            }
        }
    }
}
