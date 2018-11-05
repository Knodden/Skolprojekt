using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSreader.BusinessLayer
{
    public class Podcast
    {
		public string Title { get; set; }	
		public string URL { get; set; }
		public List<Episode> Episodes { get; set; }
		public int UpdateInterval { get; set; }
		public string Category { get; set; }
		public Podcast(string podcastURL, string podcastTitle, int podcastInterval, string podcastCategory) {
			URL = podcastURL;
			Title = podcastTitle;
			Episodes = new List<Episode>();
			UpdateInterval = podcastInterval;
			Category = podcastCategory;
		}
        public Podcast()
        {
            Episodes = new List<Episode>();
        }
    }
}

