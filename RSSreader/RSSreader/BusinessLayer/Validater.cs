using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSreader.BusinessLayer
{
    class Validater
    {
		public static bool IsURL(string URL) {
			// Kontrollera att string URL är en länk.
			{
				if (URL.Contains(@"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$")) {
					return true;
				}
				else {
					return false;
				}
			}
		}
        public static bool NotEmpty(string input) 
        {
            if(!(string.IsNullOrEmpty(input)))
            {
                return true;
            }
            else
            {
                return false;
            }
		}
		public static bool CheckCategoryExist(List<Category> categories, string newCategory) {
			bool doesExist = false;
			foreach (var c in categories) {
				if (c.Title == newCategory) {
					Dialog.CatogeryExist();
					doesExist = true;
				}
				else {
					doesExist = false;
				}
			};
			return doesExist;
		}
		internal static bool CheckPodcastExist(List<Podcast> podcast, string podcastURL) {
			bool doesExist = false;
			foreach (var c in podcast) {
				if (c.URL == podcastURL) {
					Dialog.PodcastExist();
					doesExist = true;
				}
				else {
					doesExist = false;
				}
			};
			return doesExist;
		}
	}
}
