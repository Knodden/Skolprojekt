﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using RSSreader.BusinessLayer;

namespace RSSreader {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			// Det som sker när programmet startar.
			// Ladda in XML från Podcast och Kategori och fyll listorna.
			FillPodcastListBox();
			FillCatogoryListBox();
			FillCategoryCheckbox();

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			if(lbCategory.SelectedItem == null){
				return;
			}
			else { 
				string updateCategoryTitle = lbCategory.SelectedItem.ToString();
				tbCategory.Text = updateCategoryTitle;
			}
		}
		private void btnNewPodcast_Click(object sender, EventArgs e) {
			string podcastURL = tbURL.Text.ToString();
			string podcastTitle = tbPodcastTitle.Text.ToString();
			int podcastInterval = 5;
			Object podcastCategory = cbPodcastCategory.SelectedItem;
			ListHandler.AddPodcast(podcastURL, podcastTitle, podcastInterval, podcastCategory.ToString());
			FillPodcastListBox();
		}

		private void btnSavePodcast_Click(object sender, EventArgs e) {
			// Uppdatera Podcast
		}

		private void btnRemovePodcast_Click(object sender, EventArgs e) {
			// Ta bort en Podcast
		}

		private void btnNewCategory_Click(object sender, EventArgs e) {
			ListHandler.AddCategory(tbCategory.Text.ToString());
			FillCatogoryListBox();
			tbCategory.Text = "";
		}
		private void btnRemoveCategory_Click(object sender, EventArgs e) {
			ListHandler.RemoveCategory(tbCategory.Text.ToString());
			FillCatogoryListBox();
			tbCategory.Text = "";
		}
		private void btnSaveCategory_Click(object sender, EventArgs e) {
			if(ListHandler.UpdateCategory(lbCategory.SelectedItem.ToString(), tbCategory.Text.ToString())) {
				FillCatogoryListBox();
			}
		}
		private void tbURL_TextChanged(object sender, EventArgs e) {

		}
		public void FillCatogoryListBox() {
			lbCategory.Items.Clear();
			var sortedList = ListHandler.SortCategoryList(ListHandler.ListCategory());
			foreach (var sc in sortedList) {
				lbCategory.Items.Add(sc.Title);
			};
			FillCategoryCheckbox();
		}
		public void FillCategoryCheckbox() {
			cbPodcastCategory.Items.Clear();
			var categoryList = ListHandler.ListCategory();
			if (categoryList.Any()) {
				foreach (var c in categoryList) {
					cbPodcastCategory.Items.Add(c.Title);
				}
			}
		}
		public void FillPodcastListBox() {
			lvPodcasts.Items.Clear();
			var podcastList = ListHandler.SortPodcastList();
			if (podcastList.Any()) {
				foreach (var p in podcastList) {
					ListViewItem podcast = new ListViewItem();
					podcast.Text = p.Episodes.ToString();
					podcast.SubItems.Add(p.Title);
					podcast.SubItems.Add("5");
					podcast.SubItems.Add(p.Category);
					lvPodcasts.Items.Add(podcast);
				}
			}
		}
	}
}
