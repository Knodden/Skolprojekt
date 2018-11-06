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
        public async Task FetchFeeds(List<Podcast> podcasts)
        {
            foreach(var p in podcasts)
            {
                var url = p.URL;
                var content = await Client.GetStringAsync(url);
                var episodeList = new XML().XmlToEpisode(content);
                p.Episodes = episodeList;
            }

        }
    }
}
