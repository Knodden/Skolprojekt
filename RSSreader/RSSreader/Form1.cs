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
using System.Text.RegularExpressions;

namespace RSSreader {
	public partial class Form1 : Form {
        int updateCounter = 0;
		public Form1() {
			InitializeComponent();
		}
		private async void Form1_Load(object sender, EventArgs e) {
            ListHandler.LoadData();
			FillPodcastListBox();
			FillCatogoryListBox();
			FillCategoryCheckbox();
			FillIntervalCheckbox();

            await new FetchFeed().FetchFeeds(ListHandler.ListPodcast());
		}
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			if(lbCategory.SelectedItem == null){
				return;
			}
			else { 
				string updateCategoryTitle = lbCategory.SelectedItem.ToString();
				tbCategory.Text = updateCategoryTitle;
                ShowPodcastByCategory(updateCategoryTitle);
				CategoryButtons(true);

			}
		}
		private void btnNewPodcast_Click(object sender, EventArgs e) {
			string podcastURL = tbPodcastURL.Text;
			string podcastTitle = tbPodcastTitle.Text;
			var podcastInterval = cbPodcastInterval.SelectedItem.ToString();
			var podcastCategory = cbPodcastCategory.SelectedItem.ToString();
			if (ListHandler.AddPodcast(podcastURL, podcastTitle, podcastInterval, podcastCategory.ToString())) {
				FillPodcastListBox();
				Dialog.PodcastAdded();
				tbPodcastTitle.Text = "";
				tbPodcastURL.Text = "";
				cbPodcastInterval.SelectedIndex = 0;
				cbPodcastCategory.SelectedIndex = 0;
			}
			else {
				return;
			}
		}
		private void btnSavePodcast_Click(object sender, EventArgs e) {
			var oldPodcast = ListHandler.FetchPodcast(lvPodcasts.SelectedItems[0].Text);
            var newPodcast = new Podcast(
                tbPodcastURL.Text,
                tbPodcastTitle.Text,
                int.Parse(cbPodcastInterval.SelectedItem.ToString()),
                cbPodcastCategory.SelectedItem.ToString());
			if(ListHandler.UpdatePodcast(oldPodcast, newPodcast)){
				tbPodcastTitle.Text = "";
				tbPodcastURL.Text = "";
				cbPodcastInterval.SelectedIndex = 0;
				cbPodcastCategory.SelectedIndex = 0;
				PodcastButtons(false);
				FillPodcastListBox();
			}	
        }
		private void btnRemovePodcast_Click(object sender, EventArgs e)
        {
			if (ListHandler.RemovePodcast(lvPodcasts.SelectedItems[0].Text))
            {
				FillPodcastListBox();
				tbPodcastTitle.Text = "";
				tbPodcastURL.Text = "";
				PodcastButtons(false);
			}
		}
		private void btnNewCategory_Click(object sender, EventArgs e)
        {
			ListHandler.AddCategory(tbCategory.Text.ToString());
			FillCatogoryListBox();
			tbCategory.Text = "";
		}
		private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
			if (ListHandler.RemoveCategory(tbCategory.Text.ToString()))
            { 
				FillCatogoryListBox();
				tbCategory.Text = "";
			}
		}
		private void btnSaveCategory_Click(object sender, EventArgs e)
        {
			if(ListHandler.UpdateCategory(lbCategory.SelectedItem.ToString(), tbCategory.Text.ToString()))
            {
				FillCatogoryListBox();
			}
		}
		public void FillCatogoryListBox()
        {
			lbCategory.Items.Clear();
			var sortedList = ListHandler.SortCategoryList(ListHandler.ListCategory());
			foreach (var sc in sortedList)
            {
				lbCategory.Items.Add(sc.Title);
			};
			FillCategoryCheckbox();
		}
		public void FillIntervalCheckbox()
        {
			cbPodcastInterval.Items.Clear();
			var intervalList = Interval.PossibleIntervals();
			if (intervalList.Any())
            {
				foreach (var c in intervalList)
                {
					cbPodcastInterval.Items.Add(c);
				}
			}
			cbPodcastInterval.SelectedIndex = 0;
		}
		public void FillCategoryCheckbox()
        {
			cbPodcastCategory.Items.Clear();
			var categoryList = ListHandler.ListCategory();
			if (categoryList.Any())
            {
				foreach (var c in categoryList)
                {
					cbPodcastCategory.Items.Add(c.Title);
				}
			}
			if (categoryList.Any())
            { 
				cbPodcastCategory.SelectedIndex = 0;
				cbPodcastCategory.Enabled = true;
			}
			else
            {
				cbPodcastCategory.Enabled = false;
			}
		}
		public void FillPodcastListBox()
        {
			lvPodcasts.Items.Clear();
			var podcastList = ListHandler.SortPodcastList();
			if (podcastList.Any())
            {
				foreach (var p in podcastList)
                {
					ListViewItem podcast = new ListViewItem();
					podcast.Text = p.Title;
					podcast.SubItems.Add(p.Episodes.Count.ToString());
					podcast.SubItems.Add(p.UpdateInterval.ToString());
					podcast.SubItems.Add(p.Category);
					lvPodcasts.Items.Add(podcast);
				}
			}
		}
		private void lvPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (lvPodcasts.SelectedItems == null || lvPodcasts.SelectedItems.Count == 0)
            {
				return;
			}
			else
            {
                string selectedPodcast = lvPodcasts.SelectedItems[0].Text;
                var podcast = ListHandler.FetchPodcast(selectedPodcast);
                tbPodcastTitle.Text = podcast.Title;
                tbPodcastURL.Text = podcast.URL;
                cbPodcastInterval.Text = podcast.UpdateInterval.ToString();
                cbPodcastCategory.Text = podcast.Category.ToString();
                FillVEpisodes(podcast);
                PodcastButtons(true);
                return;
            }
        }
        public void ShowPodcastByCategory(string updateCategoryTitle)
        {
            lvPodcasts.Items.Clear();
            var podcastList = ListHandler.SortByCategory(updateCategoryTitle);
            if (podcastList.Any())
            {
                foreach(var p in podcastList)
                {
                    ListViewItem podcast = new ListViewItem();
                    podcast.Text = p.Title;
                    podcast.SubItems.Add(p.Episodes.Count.ToString());
                    podcast.SubItems.Add(p.UpdateInterval.ToString());
                    podcast.SubItems.Add(p.Category);
                    lvPodcasts.Items.Add(podcast);
                }
            }
        }
		private void tbCategory_TextChanged(object sender, EventArgs e)
        {
			ShowPodcastByCategory(tbCategory.Text.ToString());
			if (!(string.IsNullOrEmpty(tbCategory.Text)))
            { 
				lbFilter.Text = "Filter by Category (" + tbCategory.Text.ToString() + ")";
				btnNewCategory.Enabled = true;
				if(!(lbCategory.SelectedItem == null))
                {
					CategoryButtons(true);
				}
			}
			else
            {
				lbFilter.Text = "Filter by Category (*)";
				CategoryButtons(false);
				btnNewCategory.Enabled = false;
			}
		}
		public void CategoryButtons(bool showButton) {
			btnRemoveCategory.Enabled = showButton;
			btnSaveCategory.Enabled = showButton;
		}
		public void PodcastButtons(bool showButton) {
			btnRemovePodcast.Enabled = showButton;
			btnSavePodcast.Enabled = showButton;
		}
        private void FillVEpisodes(Podcast podcast)
        {
            lvEpisodes.Items.Clear();
            var episodeList = podcast.Episodes;
            foreach (var e in episodeList)
            {
                ListViewItem episode = new ListViewItem();
                episode.Text = e.Title;
                episode.SubItems.Add(e.PubDate.ToString());
                lvEpisodes.Items.Add(episode);
            }
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            var all = ListHandler.ListPodcast();
            var toUpdate = all.Where(a => updateCounter % a.UpdateInterval == 0).ToList();
            updateCounter++;
            await new FetchFeed().FetchFeeds(toUpdate);
            ListHandler.SaveData();
        }
		private void lvEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (lvPodcasts.SelectedItems == null || lvPodcasts.SelectedItems.Count == 0)
            {
				return;
			}
			else {
				if (lvEpisodes.SelectedItems == null || lvEpisodes.SelectedItems.Count == 0)
                {
					return;
				}
				else
                {
					string selectedPodcast = lvPodcasts.SelectedItems[0].Text;
					var podcast = ListHandler.FetchPodcast(selectedPodcast);
					string selectedEpisode = lvEpisodes.SelectedItems[0].Text;
					string episode = ListHandler.FetchEpisode(selectedEpisode, podcast);
					lbEpisodeTitle.Text = selectedEpisode;
					string episodeNoHTML = Regex.Replace(episode, "<.*?>", String.Empty);
					tbEpsiodeDescription.Text = episodeNoHTML;

					return;
				}
			}
		}
	}
}
