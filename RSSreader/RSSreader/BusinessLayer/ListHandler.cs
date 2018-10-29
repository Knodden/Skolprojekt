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

		public void TestCreate() {
			Category cat1 = new Category("Titel1");
			Category cat2 = new Category("Titel2");
			Category cat3 = new Category("Titel3");
			Category cat4 = new Category("Titel4");
			Category cat5 = new Category("Titel5");
			listOfCategory.Add(cat1);
			listOfCategory.Add(cat2);
			listOfCategory.Add(cat3);
			listOfCategory.Add(cat4);
			listOfCategory.Add(cat5);
		}
		public List<Category> sendCatList() {
			return listOfCategory;
		}
		public static List<Category> sortList(List<Category> listToSort) {
			var newList = listToSort.OrderBy((a) => a.title).ToList();
			return newList;
		}
	}
}
