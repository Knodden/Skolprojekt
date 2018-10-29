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
					var updateCat = listOfCategory.FirstOrDefault((nv) => nv.title == oldCategory);
					updateCat.title = newCategory;
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
			var newList = listToSort.OrderBy((a) => a.title).ToList();
			return newList;
		}
		internal static void RemoveCategory(string categoryRemove) {
			bool doesExist = false;
			if (Validater.NotEmpty(categoryRemove)) {
				foreach (var c in listOfCategory) {
					if (c.title == categoryRemove) {
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

	}
}
