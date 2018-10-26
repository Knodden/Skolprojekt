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
		}

		private void tbURL_TextChanged(object sender, EventArgs e) {

		}
		// TA BORT DENNA //
		private void btnLaddaKategorier_Click(object sender, EventArgs e) {
			TestCreate();
			UpdateCategoryList();
		}
		// DETTA BÖR VARA EN EGEN KLASS... //
		public void UpdateCategoryList() {
			lbCategory.Items.Clear();
			foreach (var w in listOfCategory) {
				lbCategory.Items.Add(w.title);
			};
		}
		public void TestCreate() {
			Category cat1 = new Category("Humor");
			Category cat2 = new Category("Historia");
			Category cat3 = new Category("Drama");
			Category cat4 = new Category("Action");
			Category cat5 = new Category("Something");
			listOfCategory.Add(cat1);
			listOfCategory.Add(cat2);
			listOfCategory.Add(cat3);
			listOfCategory.Add(cat4);
			listOfCategory.Add(cat5);
		}
		public void AddCat(string catTitle) {
			bool doesExist = false;
			foreach(var c in listOfCategory) {
				if(c.title == catTitle) {
					MessageBox.Show("This category already exist.");
					tbCategory.Focus();
					doesExist = true;
				}
			}
			if (!doesExist) {
				Category createCat = new Category(catTitle);
				listOfCategory.Add(createCat);
				tbCategory.Clear();
				MessageBox.Show("Category added!");
			}
			
		}
		////////////////////////////////////////
	}
}
