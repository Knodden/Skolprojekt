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
		List<Podcast> listOfPodcast = new List<Podcast>();
		List<Category> listOfCategory = new List<Category>();

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			// Det som sker när programmet startar.
			// Ladda in XML från Podcast och Kategori och fyll listorna.

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			string updateCategoryTitle = lbCategory.SelectedItem.ToString();
			tbCategory.Text = updateCategoryTitle;
			btnRemoveCategory.Enabled = true;
			btnSaveCategory.Enabled = true;
		}

		private void btnNewPodcast_Click(object sender, EventArgs e) {
			// Skapa ny Podcast
		}

		private void btnSavePodcast_Click(object sender, EventArgs e) {
			// Uppdatera Podcast
		}

		private void btnRemovePodcast_Click(object sender, EventArgs e) {
			// Ta bort en Podcast
		}

		private void btnNewCategory_Click(object sender, EventArgs e) {
			string newCat = tbCategory.Text;
			AddCat(newCat);
			UpdateCategoryList();
		}

		private void btnSaveCategory_Click(object sender, EventArgs e) {
			// Uppdatera Kategori
			if (!(lbCategory.SelectedItem.ToString() == null)) {
				string oldCategory = lbCategory.SelectedItem.ToString();
				string newCategory = tbCategory.Text.ToString();
				if ((Validater.NotEmpty(oldCategory)) && (Validater.NotEmpty(newCategory))) {
					var updateCat = listOfCategory.FirstOrDefault((nv) => nv.title == oldCategory);
					updateCat.title = newCategory;
					Dialog.CategoryUpdated();
					UpdateCategoryList();
				}
				else {
					Dialog.EmptyInput();
				}
			}
			else {
				return;
			}
		}
		private void tbURL_TextChanged(object sender, EventArgs e) {

		}
		// TA BORT DENNA //
		// DETTA BÖR VARA EN EGEN KLASS... //
		public void RemoveCategory(string categoryToRemove) {
			listOfCategory.RemoveAll((x) => x.title == categoryToRemove);
			UpdateCategoryList();
			Dialog.CategoryRemoved();
		}
		public void UpdateCategoryList() {
			lbCategory.Items.Clear();
			var sortedList = ListHandler.sortList(listOfCategory);
			foreach (var sc in sortedList) {
				lbCategory.Items.Add(sc.title);
			};
		}
		public void AddCat(string catTitle) {
			bool doesExist = false;
			if (Validater.NotEmpty(catTitle)){ 
				foreach (var c in listOfCategory) {
					if (c.title == catTitle) {
						Dialog.CatogeryExist();
						tbCategory.Focus();
						doesExist = true;
					}
				};
				if (!doesExist) {
					Category createCat = new Category(catTitle);
					listOfCategory.Add(createCat);
					tbCategory.Clear();
					Dialog.CategoryAdded();
					if (btnRemoveCategory.Enabled) {
						btnRemoveCategory.Enabled = false;
					}
				}
			}
			else {
				Dialog.EmptyInput();
			}
		}
		private void btnRemoveCategory_Click(object sender, EventArgs e) {
			string categoryToRemove = lbCategory.SelectedItem.ToString();
			bool doesExist = false;
			if (Validater.NotEmpty(categoryToRemove)) {
				foreach (var c in listOfCategory) {
					if (c.title == categoryToRemove) {
						listOfCategory.Remove(c);
						UpdateCategoryList();
						btnRemoveCategory.Enabled = false;
						doesExist = true;
						tbCategory.Text = "";
						Dialog.CategoryRemoved();
						break;
					}
				}
				if (!doesExist) { 
					Dialog.CatogeryNotExist();
					tbCategory.Focus();
				}
			}
		}
		////////////////////////////////////////
	}
}
