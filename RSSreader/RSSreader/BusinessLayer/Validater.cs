using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ServiceModel.Syndication;
using System.Xml;

namespace RSSreader.BusinessLayer
{
    class Validater	
    {
		internal static bool IsURL(string URL) {
			try {
				SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(URL));
				foreach (SyndicationItem item in feed.Items) {
					Debug.Print(item.Title.Text);
				}
				return true;
			}
			catch (Exception) {
				return false;
			}
		}
        internal static bool NotEmpty(string input){
            if(!(string.IsNullOrEmpty(input))){
                return true;
            }
            else {
                return false;
            }
		}
		internal static bool NotEmpty(Podcast newPodcast) {
			if((string.IsNullOrEmpty(newPodcast.Title)) || (string.IsNullOrEmpty(newPodcast.URL))){
				return false;
			}
			else {
				return true;
			}
		}
		internal static bool CheckCategoryExist(List<Category> categories, string newCategory) {
			bool doesExist = false;
			foreach (var c in categories) {
				if (c.Title == newCategory) {
					doesExist = true;
					break;
				}
				else {
					doesExist = false;
				}
			};
			return doesExist;
		}
		internal static bool CheckPodcastExist(List<Podcast> podcast, string podcastURL, string podcastTitle) {
			bool doesExist = false;
			foreach (var c in podcast) {
				if ((c.URL == podcastURL) || (c.Title == podcastTitle)) {
					doesExist = true;
					break;
				}
				else {
					doesExist = false;
				}
			};
			return doesExist;
		}
        internal static bool CheckUrlExists(List<Podcast> podcasts, string newUrl){
            bool doesExist = false;
            foreach(var p in podcasts){
                if(p.URL == newUrl){
                    Dialog.NotURL();
                    doesExist = true;
					break;
                }
                else{
                    doesExist = false;
                }
            };
            return doesExist;
        }
		internal static bool CheckIfCategoryUsed(string categoryTitle) {
			bool isInUse = false;
			var podcastList = ListHandler.SortPodcastList();
			foreach(var c in podcastList) {
				if(c.Category == categoryTitle) {
					isInUse = true;
					break;
				}
			}
			return isInUse;
		}
		internal static bool CheckIfPodcastChanged(Podcast podcast1, Podcast podcast2) {
			bool isPodcastChanged = false;
			if (
				(podcast1.Title == podcast2.Title) &&
				(podcast1.URL == podcast2.URL) &&
				(podcast1.UpdateInterval == podcast2.UpdateInterval) &&
				(podcast1.Category == podcast2.Category)) {
				isPodcastChanged = false;
			}
			else {
				isPodcastChanged = true;
			}
			return isPodcastChanged;
		}

	}
}
