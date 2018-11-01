using System;
using System.Collections.Generic;
using System.Linq;
using RSSreader.DataAcessLayer;

namespace RSSreader.BusinessLayer {
	class ListHandler {
		private static List<Podcast> listOfPodcast = new List<Podcast>();
		private static List<Category> listOfCategory = new List<Category>();
		//private static FileHandler Files = new FileHandler();

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
                    new FileHandler().SaveCategories(listOfCategory);
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
					if (Validater.CheckIfCategoryUsed(oldCategory)) {
						Dialog.CategoryUsed();
					}
					else {
						var updateCat = listOfCategory.FirstOrDefault((nv) => nv.Title == oldCategory);
						updateCat.Title = newCategory;
						Dialog.CategoryUpdated();
						isCategoryUpdated = true;
                        new FileHandler().SaveCategories(listOfCategory);
					}
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
		internal static bool RemoveCategory(string categoryRemove) {
			bool doesExist = false;
			if (Validater.NotEmpty(categoryRemove)) {
				foreach (var c in listOfCategory) {
					if (c.Title == categoryRemove) {
						if (Validater.CheckIfCategoryUsed(categoryRemove)) {
							Dialog.CategoryUsed();
						}
						else {
							listOfCategory.Remove(c);
							doesExist = true;
							Dialog.CategoryRemoved();
                            break;
						}
					}
				}
                new FileHandler().SaveCategories(listOfCategory);
                if (!doesExist) {
					Dialog.CatogeryNotExist();
				}
			}
			return doesExist;
		}
		/* ---------------- */
		public static List<Podcast> ListPodcast() {
			return listOfPodcast;
		}
		public static void AddPodcast
			(string nPodcastURL, string nPodcastTitle, string nPodcastInterval, string nPodcastCategory) {
			if ((Validater.NotEmpty(nPodcastURL)) && (Validater.NotEmpty(nPodcastTitle)) && (Validater.NotEmpty(nPodcastInterval)) &&(Validater.NotEmpty(nPodcastCategory))) {
				if ((Validater.IsURL(nPodcastURL))) {
					if (Validater.CheckPodcastExist(listOfPodcast, nPodcastURL)) {
						Dialog.PodcastExist();
					}
					else {
						int nPodcastIntervalInt = int.Parse(nPodcastInterval);
						Podcast createPodcast = new Podcast(nPodcastURL, nPodcastTitle, nPodcastIntervalInt, nPodcastCategory);
						listOfPodcast.Add(createPodcast);
						Dialog.PodcastAdded();
                        new FileHandler().SavePodcasts(listOfPodcast);
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
			bool isPodcastUpdated = false;

			return isPodcastUpdated;
		}
		public static List<Podcast> SortPodcastList() {
			var newList = listOfPodcast.OrderBy((a) => a.Title).ToList();
			return newList;
		}
		internal static bool RemovePodcast(string podcastRemove) {
			bool postcastRemoved = false;
			if (Validater.NotEmpty(podcastRemove)) {
				foreach (var c in listOfPodcast) {
					if (c.Title == podcastRemove) {
						listOfPodcast.Remove(c);
						postcastRemoved = true;
						break;
					}
                    new FileHandler().SavePodcasts(listOfPodcast);
                }	
			}
			return postcastRemoved;
		}
		//internal static void LoadXML() {
		//	listOfCategory = Files.LoadCategories();
		//	listOfPodcast = Files.LoadPodcasts();
		//}
		//internal static void SaveToXML() {
		//	Files.SaveCategories(listOfCategory);
		//	Files.SavePodcasts(listOfPodcast);
		//}
	}
}
