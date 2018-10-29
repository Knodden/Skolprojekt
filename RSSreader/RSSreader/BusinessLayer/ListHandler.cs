using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSSreader.Properties;

namespace RSSreader.BusinessLayer {
	class ListHandler {
		List<Podcast> listOfPodcast = new List<Podcast>();
		List<Category> listOfCategory = new List<Category>();

		public List<Category> sendCatList() {
			return listOfCategory;
		}
		public static List<Category> sortList(List<Category> listToSort) {
			var newList = listToSort.OrderBy((a) => a.title).ToList();
			return newList;
		}
	}
}
