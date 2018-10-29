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
		Validate validator = new Validate();


		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			// Det som sker när programmet startar.
			// Ladda in XML från Podcast och Kategori och fyll listorna.

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			tbCategory.Text = lbCategory.SelectedItem.ToString();
		}

		private void btnNyPodcast_Click(object sender, EventArgs e) {
			// Skapa ny Podcast
		}

		private void btnSparaPodcast_Click(object sender, EventArgs e) {
			// Uppdatera Podcast
		}

		private void btnTaBortPodcast_Click(object sender, EventArgs e) {
			// Ta bort en Podcast
		}

		private void btnNyKategori_Click(object sender, EventArgs e) {
			string newCat = tbCategory.Text;
			AddCat(newCat);
			UpdateCategoryList();
		}

		private void btnSparaKategori_Click(object sender, EventArgs e) {
			// Uppdatera Kategori
		}

		private void btnTaBortKategori_Click(object sender, EventArgs e) {
			// Ta bort Kategori
			MessageBox.Show("TEST");
			string categoryToRemove = lbCategory.SelectedItem.ToString();
			RemoveCategory(categoryToRemove);

		}
		private void tbURL_TextChanged(object sender, EventArgs e) {

		}
		// TA BORT DENNA //
		// DETTA BÖR VARA EN EGEN KLASS... //
		public void RemoveCategory(string removeCat) {
			listOfCategory.RemoveAll((x) => x.title == removeCat);
			MessageBox.Show(removeCat + " is removed.");
			UpdateCategoryList();

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
			if (validator.NotEmpty(catTitle)){ 
				foreach (var c in listOfCategory) {
					if (c.title == catTitle) {
						MessageBox.Show("This category already exist.");
						tbCategory.Focus();
						doesExist = true;
					}
				};
				if (!doesExist) {
					Category createCat = new Category(catTitle);
					listOfCategory.Add(createCat);
					tbCategory.Clear();
					MessageBox.Show("Category added!");
				}
			}
			else {
				ErrorMessage.EmptyInput();
			}
		}
		private void btnRemoveCategory_Click(object sender, EventArgs e) {

		}
		////////////////////////////////////////
	}
}
