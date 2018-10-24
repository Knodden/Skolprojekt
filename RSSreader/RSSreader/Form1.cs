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

namespace RSSreader {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

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
			// Skapa en ny Kategori
		}

		private void btnSparaKategori_Click(object sender, EventArgs e) {
			// Uppdatera Kategori
		}

		private void btnTaBortKategori_Click(object sender, EventArgs e) {
			// Ta bort Kategori
		}
	}
}
