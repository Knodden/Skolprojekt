using System;
using System.Collections.Generic;
using System.Linq;
using RSSreader.DataAcessLayer;

namespace RSSreader.BusinessLayer {
	class ListHandler {
		private static List<Podcast> listOfPodcast = new List<Podcast>();
		private static List<Category> listOfCategory = new List<Category>();

		public static List<Category> ListCategory() {
			return listOfCategory;
		}
		public static void AddCategory(string newCategory) {
			if (Validater.NotEmpty(newCategory)) {
				if (Validater.CheckCategoryExist(listOfCategory, newCategory)) {
					Dialog.CatogeryExist();
				}
				else {
					Category createCat = new Category(newCategory);
					listOfCategory.Add(createCat);
					Dialog.CategoryAdded();
				}
			}
			else {
				Dialog.EmptyInput();
			}
		}
		internal static bool UpdateCategory(string oldCategory, string newCategory) {
			bool isCategoryUpdated = false;
			if((Validater.NotEmpty(oldCategory)) && (Validater.NotEmpty(newCategory))) {
				if (!(oldCategory == newCategory)) {
					var updateCat = listOfCategory.FirstOrDefault((nv) => nv.Title == oldCategory);
					updateCat.Title = newCategory;
					Dialog.CategoryUpdated();
					isCategoryUpdated = true;
				}
				else {
					Dialog.NoChange();
				}
			}
			else {
				Dialog.EmptyInput();
			}
			return isCategoryUpdated;
		}
		public static List<Category> SortCategoryList(List<Category> listToSort) {
			var newList = listToSort.OrderBy((a) => a.Title).ToList();
			return newList;
		}
		internal static void RemoveCategory(string categoryRemove) {
			bool doesExist = false;
			if (Validater.NotEmpty(categoryRemove)) {
				foreach (var c in listOfCategory) {
					if (c.Title == categoryRemove) {
						listOfCategory.Remove(c);
						doesExist = true;
						Dialog.CategoryRemoved();
						break;
					}
				}
				if (!doesExist) {
					Dialog.CatogeryNotExist();
				}
			}
		}
		/* ---------------- */
		public List<Podcast> ListPodcast() {
			return listOfPodcast;
		}
		public static void AddPodcast
			(string nPodcastURL, string nPodcastTitle, int nPodcastInterval, string nPodcastCategory) {
			if ((Validater.NotEmpty(nPodcastURL)) && (Validater.NotEmpty(nPodcastTitle)) && (Validater.NotEmpty(nPodcastCategory))) {
				if ((Validater.IsURL(nPodcastURL))) {
					if (Validater.CheckPodcastExist(listOfPodcast, nPodcastURL)) {
						Dialog.PodcastExist();
					}
					else {
						Podcast createPodcast = new Podcast(nPodcastURL, nPodcastTitle, nPodcastInterval, nPodcastCategory);
						listOfPodcast.Add(createPodcast);
						Dialog.PodcastAdded();
					}
				}
				else {
					Dialog.NotURL();
				}
			}
			else {
				Dialog.EmptyInput();
			}
		}
		internal static bool UpdatePodcast(string oldPodcastTitle, string newPodCastTitle) {
			bool isCategoryUpdated = false;
			if ((Validater.NotEmpty(oldPodcastTitle)) && (Validater.NotEmpty(newPodCastTitle))) {
				if (!(oldPodcastTitle == newPodCastTitle)) {
					var updatePodcast = listOfPodcast.FirstOrDefault((np) => np.Title == oldPodcastTitle);
					updatePodcast.Title = newPodCastTitle;
					Dialog.CategoryUpdated();
					isCategoryUpdated = true;
				}
				else {
					Dialog.NoChange();
				}
			}
			else {
				Dialog.EmptyInput();
			}
			return isCategoryUpdated;
		}
		public static List<Podcast> SortPodcastList() {
			var newList = listOfPodcast.OrderBy((a) => a.Title).ToList();
			return newList;
		}
		internal static void RemovePodcast(string categoryRemove) {
			bool doesExist = false;
			
		}
	}
}
