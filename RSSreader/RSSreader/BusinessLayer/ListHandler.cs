using System;
using System.Collections.Generic;
using System.Linq;
using RSSreader.DataAcessLayer;

namespace RSSreader.BusinessLayer
{
    class ListHandler
    {
        private static List<Podcast> listOfPodcast = new List<Podcast>();
        private static List<Category> listOfCategory = new List<Category>();

        public static void LoadData()
        {
            listOfCategory = new FileHandler().LoadCategories();
            listOfPodcast = new FileHandler().LoadPodcasts();
        }
        public static void SaveData()
        {
            new FileHandler().SavePodcasts(listOfPodcast);
        }
        public static List<Category> ListCategory()
        {
            return listOfCategory;
        }
        public static void AddCategory(string newCategory)
        {
            if (Validater.NotEmpty(newCategory))
            {
                if (Validater.CheckCategoryExist(listOfCategory, newCategory))
                {
                    Dialog.CatogeryExist();
                }
                else
                {
                    Category createCat = new Category(newCategory);
                    listOfCategory.Add(createCat);
                    Dialog.CategoryAdded();
                    new FileHandler().SaveCategories(listOfCategory);
                }
            }
            else
            {
                new Dialog().EmptyInput();
            }
        }
        internal static bool UpdateCategory(string oldCategory, string newCategory)
        {
            bool isCategoryUpdated = false;
            if ((Validater.NotEmpty(oldCategory)) && (Validater.NotEmpty(newCategory)))
            {
                if (!(oldCategory == newCategory))
                {
                    if (Validater.CheckIfCategoryUsed(oldCategory))
                    {
                        Dialog.CategoryUsed();
                    }
                    else
                    {
                        var updateCat = listOfCategory.FirstOrDefault((nv) => nv.Title == oldCategory);
                        updateCat.Title = newCategory;
                        Dialog.CategoryUpdated();
                        isCategoryUpdated = true;
                        new FileHandler().SaveCategories(listOfCategory);
                    }
                }
                else
                {
                    Dialog.NoChange();
                }
            }
            else
            {
                new Dialog().EmptyInput();
            }
            return isCategoryUpdated;
        }
        internal static bool UpdatePodcast(Podcast oldPodcast, Podcast newPodcast)
        {
            bool isPodcastUpdate = false;
            if (Validater.CheckIfPodcastChanged(oldPodcast, newPodcast))
            {
                bool updatePodcast = true;
                foreach (var p in listOfPodcast)
                {
                    if ((p.Title == newPodcast.Title) && !(oldPodcast.Title == newPodcast.Title))
                    {
                        Dialog.PodcastExist();
                        updatePodcast = false;
                        break;
                    }
                }
                if (updatePodcast)
                {
					if (Validater.NotEmpty(newPodcast)) {
						if ((Validater.IsURL(newPodcast.URL))) {
							ListHandler.RemovePodcast(oldPodcast.Title);
							listOfPodcast.Add(newPodcast);
							new FileHandler().SavePodcasts(listOfPodcast);
							isPodcastUpdate = true;
							Dialog.PodcastUpdated();
						}
						else {
							Dialog.NotURL();
						}
					}
					else {
						new Dialog().EmptyInput();
					}
			
                }
            }
            return isPodcastUpdate;
        }

        public static List<Category> SortCategoryList(List<Category> listToSort)
        {
            var newList = listToSort.OrderBy((a) => a.Title).ToList();
            return newList;
        }
        internal static bool RemoveCategory(string categoryRemove)
        {
            bool catDeleted = false;
            if (Validater.NotEmpty(categoryRemove))
            {
                foreach (var c in listOfCategory)
                {
                    if (c.Title == categoryRemove)
                    {
                        if (Validater.CheckIfCategoryUsed(categoryRemove))
                        {
                            Dialog.CategoryUsed();
                        }
                        else
                        {
                            listOfCategory.Remove(c);
                            catDeleted = true;
                            //Dialog.CategoryRemoved();
                            break;
                        }
                    }
                }
                new FileHandler().SaveCategories(listOfCategory);
            }
            return catDeleted;
        }
        public static List<Podcast> ListPodcast()
        {
            return listOfPodcast;
        }
        public static bool AddPodcast
            (string nPodcastURL, string nPodcastTitle, string nPodcastInterval, string nPodcastCategory)
        {
            bool podcastAdded = false;
            if ((Validater.NotEmpty(nPodcastURL)) && (Validater.NotEmpty(nPodcastTitle)) && (Validater.NotEmpty(nPodcastInterval)) && (Validater.NotEmpty(nPodcastCategory)))
            {
                if ((Validater.IsURL(nPodcastURL)))
                {
                    if (Validater.CheckPodcastExist(listOfPodcast, nPodcastURL, nPodcastTitle))
                    {
                        Dialog.PodcastExist();
                    }
                    else
                    {
                        int nPodcastIntervalInt = int.Parse(nPodcastInterval);
                        Podcast createPodcast = new Podcast(nPodcastURL, nPodcastTitle, nPodcastIntervalInt, nPodcastCategory);
                        listOfPodcast.Add(createPodcast);
                        podcastAdded = true;
                        new FileHandler().SavePodcasts(listOfPodcast);
                    }
                }
                else
                {
                    Dialog.NotURL();
                }
            }
            else
            {
                new Dialog().EmptyInput();
            }
            return podcastAdded;
        }
        public static List<Podcast> SortPodcastList()
        {
            var newList = listOfPodcast.OrderBy((a) => a.Title).ToList();
            return newList;
        }
        public static List<Podcast> SortByCategory(string updateCategoryTitle)
        {
            var newList = listOfPodcast.Where(p => p.Category.Contains(updateCategoryTitle)).OrderBy(p => p.Title).ToList();
            return newList;
        }
        internal static bool RemovePodcast(string podcastRemove)
        {
            bool postcastRemoved = false;
            if (Validater.NotEmpty(podcastRemove))
            {
                foreach (var c in listOfPodcast)
                {
                    if (c.Title == podcastRemove)
                    {
                        listOfPodcast.Remove(c);
                        postcastRemoved = true;
                        new FileHandler().SavePodcasts(listOfPodcast);
                        break;
                    }
                }
            }
            return postcastRemoved;
        }
        internal static Podcast FetchPodcast(string podcastTitle)
        {
            foreach (var p in listOfPodcast)
            {
                if (p.Title == podcastTitle)
                {
					return p;
                }
            }
			return null;
        }
		internal static string FetchEpisode(string selectedEpisode, Podcast selectedPodcast) {
			foreach(var e in selectedPodcast.Episodes) {
				if(e.Title == selectedEpisode) {
					return e.Description;
				}
			}
			return null;
		}
	}
}
