using System;
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
            ListHandler.LoadData();
			FillPodcastListBox();
			FillCatogoryListBox();
			FillCategoryCheckbox();
			FillIntervalCheckbox();
		}
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			if(lbCategory.SelectedItem == null){
				return;
			}
			else { 
				string updateCategoryTitle = lbCategory.SelectedItem.ToString();
				tbCategory.Text = updateCategoryTitle;
				btnSaveCategory.Enabled = true;
				btnRemoveCategory.Enabled = true;
			}
		}
		private void btnNewPodcast_Click(object sender, EventArgs e) {
			string podcastURL = tbPodcastURL.Text;
			string podcastTitle = tbPodcastTitle.Text;
			var podcastInterval = cbPodcastInterval.SelectedItem.ToString();
			var podcastCategory = cbPodcastCategory.SelectedItem.ToString();
			if (ListHandler.AddPodcast(podcastURL, podcastTitle, podcastInterval, podcastCategory.ToString())) {
				FillPodcastListBox();
				tbPodcastTitle.Text = "";
				tbPodcastURL.Text = "";
				cbPodcastInterval.SelectedIndex = 0;
				cbPodcastCategory.SelectedIndex = 0;
			}
		}
		private void btnSavePodcast_Click(object sender, EventArgs e) {
			var oldPodcast = ListHandler.FetchPodcast(lvPodcasts.SelectedItems[0].Text);
            var newPodcast = new Podcast(
                tbPodcastURL.Text,
                tbPodcastTitle.Text,
                int.Parse(cbPodcastInterval.SelectedItem.ToString()),
                cbPodcastCategory.SelectedItem.ToString());
			ListHandler.UpdatePodcast(oldPodcast, newPodcast);
            FillPodcastListBox();
        }

		private void btnRemovePodcast_Click(object sender, EventArgs e) {
			if (ListHandler.RemovePodcast(lvPodcasts.SelectedItems[0].Text)) {
				FillPodcastListBox();
				tbPodcastTitle.Text = "";
				tbPodcastURL.Text = "";
			}
		}
		private void btnNewCategory_Click(object sender, EventArgs e) {
			ListHandler.AddCategory(tbCategory.Text.ToString());
			FillCatogoryListBox();
			tbCategory.Text = "";
		}
		private void btnRemoveCategory_Click(object sender, EventArgs e) {
			if (ListHandler.RemoveCategory(tbCategory.Text.ToString())) { 
				FillCatogoryListBox();
				tbCategory.Text = "";
				btnSaveCategory.Enabled = false;
				btnRemoveCategory.Enabled = false;
			}
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
		public void FillIntervalCheckbox() {
			cbPodcastInterval.Items.Clear();
			var intervalList = Interval.PossibleIntervals();
			if (intervalList.Any()) {
				foreach (var c in intervalList) {
					cbPodcastInterval.Items.Add(c);
				}
			}
			cbPodcastInterval.SelectedIndex = 0;
		}
		public void FillCategoryCheckbox() {
			cbPodcastCategory.Items.Clear();
			var categoryList = ListHandler.ListCategory();
			if (categoryList.Any()) {
				foreach (var c in categoryList) {
					cbPodcastCategory.Items.Add(c.Title);
				}
			}
			if (categoryList.Any()) { 
				cbPodcastCategory.SelectedIndex = 0;
				btnNewPodcast.Enabled = true;
				btnSavePodcast.Enabled = true;
				cbPodcastCategory.Enabled = true;
			}
			else {
				btnNewPodcast.Enabled = false;
				btnSavePodcast.Enabled = false;
				cbPodcastCategory.Enabled = false;
			}
		}
		public void FillPodcastListBox() {
			lvPodcasts.Items.Clear();
			var podcastList = ListHandler.SortPodcastList();
			if (podcastList.Any()) {
				foreach (var p in podcastList) {
					ListViewItem podcast = new ListViewItem();
					podcast.Text = p.Title;
					podcast.SubItems.Add(p.Episodes.Count.ToString());
					podcast.SubItems.Add(p.UpdateInterval.ToString());
					podcast.SubItems.Add(p.Category);
					lvPodcasts.Items.Add(podcast);
				}
			}
		}

		private void lvPodcasts_SelectedIndexChanged(object sender, EventArgs e) {
			if (lvPodcasts.SelectedItems == null || lvPodcasts.SelectedItems.Count == 0) {
				return;
			}
			else {
				string updatePodcastTitle = lvPodcasts.SelectedItems[0].Text;
				var podcast = ListHandler.FetchPodcast(updatePodcastTitle);
				tbPodcastTitle.Text = podcast.Title;
				tbPodcastURL.Text = podcast.URL;
				cbPodcastInterval.SelectedText = podcast.UpdateInterval.ToString();
				cbPodcastCategory.SelectedText = podcast.Category.ToString();

				// Kod för att uppdatera en podcast.
			}
		}
	}
}
