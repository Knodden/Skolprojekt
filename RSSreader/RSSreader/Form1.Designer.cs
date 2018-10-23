namespace RSSreader {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lbPodcastRubrik = new System.Windows.Forms.Label();
			this.lvPodcasts = new System.Windows.Forms.ListView();
			this.chAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbKategorier = new System.Windows.Forms.ListBox();
			this.lbKategoriRubrik = new System.Windows.Forms.Label();
			this.lbURL = new System.Windows.Forms.Label();
			this.tbURL = new System.Windows.Forms.TextBox();
			this.lbTitel = new System.Windows.Forms.Label();
			this.tbTitel = new System.Windows.Forms.TextBox();
			this.lbFrekvens = new System.Windows.Forms.Label();
			this.cbFrekvens = new System.Windows.Forms.ComboBox();
			this.lbKategori = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tbKategor = new System.Windows.Forms.TextBox();
			this.btnNyKategori = new System.Windows.Forms.Button();
			this.btnSparaKategori = new System.Windows.Forms.Button();
			this.btnTaBortKategori = new System.Windows.Forms.Button();
			this.btnNyPodcast = new System.Windows.Forms.Button();
			this.btnSparaPodcast = new System.Windows.Forms.Button();
			this.btnTaBortPodcast = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.lbAntalAvsnitt = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbPodcastRubrik
			// 
			this.lbPodcastRubrik.AutoSize = true;
			this.lbPodcastRubrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPodcastRubrik.Location = new System.Drawing.Point(12, 9);
			this.lbPodcastRubrik.Name = "lbPodcastRubrik";
			this.lbPodcastRubrik.Size = new System.Drawing.Size(74, 17);
			this.lbPodcastRubrik.TabIndex = 1;
			this.lbPodcastRubrik.Text = "Podcasts";
			this.lbPodcastRubrik.UseWaitCursor = true;
			// 
			// lvPodcasts
			// 
			this.lvPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAvsnitt,
            this.chTitel,
            this.chFrekvens,
            this.chKategori});
			this.lvPodcasts.Location = new System.Drawing.Point(15, 30);
			this.lvPodcasts.Name = "lvPodcasts";
			this.lvPodcasts.Size = new System.Drawing.Size(559, 160);
			this.lvPodcasts.TabIndex = 2;
			this.lvPodcasts.UseCompatibleStateImageBehavior = false;
			this.lvPodcasts.UseWaitCursor = true;
			this.lvPodcasts.View = System.Windows.Forms.View.Details;
			// 
			// chAvsnitt
			// 
			this.chAvsnitt.Text = "Avsnitt";
			// 
			// chTitel
			// 
			this.chTitel.Text = "Titel";
			this.chTitel.Width = 273;
			// 
			// chFrekvens
			// 
			this.chFrekvens.Text = "Frekvens";
			this.chFrekvens.Width = 71;
			// 
			// chKategori
			// 
			this.chKategori.Text = "Kategori";
			this.chKategori.Width = 100;
			// 
			// lbKategorier
			// 
			this.lbKategorier.FormattingEnabled = true;
			this.lbKategorier.ItemHeight = 16;
			this.lbKategorier.Location = new System.Drawing.Point(635, 30);
			this.lbKategorier.Name = "lbKategorier";
			this.lbKategorier.Size = new System.Drawing.Size(248, 132);
			this.lbKategorier.TabIndex = 3;
			this.lbKategorier.UseWaitCursor = true;
			this.lbKategorier.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// lbKategoriRubrik
			// 
			this.lbKategoriRubrik.AutoSize = true;
			this.lbKategoriRubrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKategoriRubrik.Location = new System.Drawing.Point(632, 10);
			this.lbKategoriRubrik.Name = "lbKategoriRubrik";
			this.lbKategoriRubrik.Size = new System.Drawing.Size(84, 17);
			this.lbKategoriRubrik.TabIndex = 4;
			this.lbKategoriRubrik.Text = "Kategorier";
			this.lbKategoriRubrik.UseWaitCursor = true;
			// 
			// lbURL
			// 
			this.lbURL.AutoSize = true;
			this.lbURL.Location = new System.Drawing.Point(13, 201);
			this.lbURL.Name = "lbURL";
			this.lbURL.Size = new System.Drawing.Size(36, 17);
			this.lbURL.TabIndex = 5;
			this.lbURL.Text = "URL";
			this.lbURL.UseWaitCursor = true;
			// 
			// tbURL
			// 
			this.tbURL.Location = new System.Drawing.Point(16, 222);
			this.tbURL.Name = "tbURL";
			this.tbURL.Size = new System.Drawing.Size(150, 22);
			this.tbURL.TabIndex = 6;
			this.tbURL.UseWaitCursor = true;
			// 
			// lbTitel
			// 
			this.lbTitel.AutoSize = true;
			this.lbTitel.Location = new System.Drawing.Point(173, 201);
			this.lbTitel.Name = "lbTitel";
			this.lbTitel.Size = new System.Drawing.Size(35, 17);
			this.lbTitel.TabIndex = 7;
			this.lbTitel.Text = "Titel";
			this.lbTitel.UseWaitCursor = true;
			// 
			// tbTitel
			// 
			this.tbTitel.AllowDrop = true;
			this.tbTitel.Location = new System.Drawing.Point(176, 222);
			this.tbTitel.Name = "tbTitel";
			this.tbTitel.Size = new System.Drawing.Size(136, 22);
			this.tbTitel.TabIndex = 8;
			this.tbTitel.UseWaitCursor = true;
			// 
			// lbFrekvens
			// 
			this.lbFrekvens.AutoSize = true;
			this.lbFrekvens.Location = new System.Drawing.Point(319, 201);
			this.lbFrekvens.Name = "lbFrekvens";
			this.lbFrekvens.Size = new System.Drawing.Size(66, 17);
			this.lbFrekvens.TabIndex = 9;
			this.lbFrekvens.Text = "Frekvens";
			this.lbFrekvens.UseWaitCursor = true;
			// 
			// cbFrekvens
			// 
			this.cbFrekvens.FormattingEnabled = true;
			this.cbFrekvens.Location = new System.Drawing.Point(322, 222);
			this.cbFrekvens.Name = "cbFrekvens";
			this.cbFrekvens.Size = new System.Drawing.Size(121, 24);
			this.cbFrekvens.TabIndex = 10;
			this.cbFrekvens.UseWaitCursor = true;
			// 
			// lbKategori
			// 
			this.lbKategori.AutoSize = true;
			this.lbKategori.Location = new System.Drawing.Point(450, 201);
			this.lbKategori.Name = "lbKategori";
			this.lbKategori.Size = new System.Drawing.Size(61, 17);
			this.lbKategori.TabIndex = 11;
			this.lbKategori.Text = "Kategori";
			this.lbKategori.UseWaitCursor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(453, 222);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 12;
			this.comboBox1.UseWaitCursor = true;
			// 
			// tbKategor
			// 
			this.tbKategor.Location = new System.Drawing.Point(635, 168);
			this.tbKategor.Name = "tbKategor";
			this.tbKategor.Size = new System.Drawing.Size(248, 22);
			this.tbKategor.TabIndex = 13;
			this.tbKategor.UseWaitCursor = true;
			// 
			// btnNyKategori
			// 
			this.btnNyKategori.Location = new System.Drawing.Point(635, 196);
			this.btnNyKategori.Name = "btnNyKategori";
			this.btnNyKategori.Size = new System.Drawing.Size(121, 23);
			this.btnNyKategori.TabIndex = 14;
			this.btnNyKategori.Text = "Ny..";
			this.btnNyKategori.UseVisualStyleBackColor = true;
			this.btnNyKategori.UseWaitCursor = true;
			// 
			// btnSparaKategori
			// 
			this.btnSparaKategori.Location = new System.Drawing.Point(762, 196);
			this.btnSparaKategori.Name = "btnSparaKategori";
			this.btnSparaKategori.Size = new System.Drawing.Size(121, 23);
			this.btnSparaKategori.TabIndex = 15;
			this.btnSparaKategori.Text = "Spara";
			this.btnSparaKategori.UseVisualStyleBackColor = true;
			this.btnSparaKategori.UseWaitCursor = true;
			// 
			// btnTaBortKategori
			// 
			this.btnTaBortKategori.Location = new System.Drawing.Point(635, 225);
			this.btnTaBortKategori.Name = "btnTaBortKategori";
			this.btnTaBortKategori.Size = new System.Drawing.Size(121, 23);
			this.btnTaBortKategori.TabIndex = 16;
			this.btnTaBortKategori.Text = "Ta bort";
			this.btnTaBortKategori.UseVisualStyleBackColor = true;
			this.btnTaBortKategori.UseWaitCursor = true;
			// 
			// btnNyPodcast
			// 
			this.btnNyPodcast.Location = new System.Drawing.Point(191, 254);
			this.btnNyPodcast.Name = "btnNyPodcast";
			this.btnNyPodcast.Size = new System.Drawing.Size(121, 23);
			this.btnNyPodcast.TabIndex = 17;
			this.btnNyPodcast.Text = "Ny..";
			this.btnNyPodcast.UseVisualStyleBackColor = true;
			this.btnNyPodcast.UseWaitCursor = true;
			// 
			// btnSparaPodcast
			// 
			this.btnSparaPodcast.Location = new System.Drawing.Point(322, 254);
			this.btnSparaPodcast.Name = "btnSparaPodcast";
			this.btnSparaPodcast.Size = new System.Drawing.Size(121, 23);
			this.btnSparaPodcast.TabIndex = 18;
			this.btnSparaPodcast.Text = "Spara";
			this.btnSparaPodcast.UseVisualStyleBackColor = true;
			this.btnSparaPodcast.UseWaitCursor = true;
			// 
			// btnTaBortPodcast
			// 
			this.btnTaBortPodcast.Location = new System.Drawing.Point(453, 254);
			this.btnTaBortPodcast.Name = "btnTaBortPodcast";
			this.btnTaBortPodcast.Size = new System.Drawing.Size(121, 23);
			this.btnTaBortPodcast.TabIndex = 19;
			this.btnTaBortPodcast.Text = "Ta bort";
			this.btnTaBortPodcast.UseVisualStyleBackColor = true;
			this.btnTaBortPodcast.UseWaitCursor = true;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(16, 307);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(296, 112);
			this.listView1.TabIndex = 20;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// lbAntalAvsnitt
			// 
			this.lbAntalAvsnitt.AutoSize = true;
			this.lbAntalAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAntalAvsnitt.Location = new System.Drawing.Point(13, 287);
			this.lbAntalAvsnitt.Name = "lbAntalAvsnitt";
			this.lbAntalAvsnitt.Size = new System.Drawing.Size(57, 17);
			this.lbAntalAvsnitt.TabIndex = 21;
			this.lbAntalAvsnitt.Text = "Avsnitt";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(901, 450);
			this.Controls.Add(this.lbAntalAvsnitt);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnTaBortPodcast);
			this.Controls.Add(this.btnSparaPodcast);
			this.Controls.Add(this.btnNyPodcast);
			this.Controls.Add(this.btnTaBortKategori);
			this.Controls.Add(this.btnSparaKategori);
			this.Controls.Add(this.btnNyKategori);
			this.Controls.Add(this.tbKategor);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lbKategori);
			this.Controls.Add(this.cbFrekvens);
			this.Controls.Add(this.lbFrekvens);
			this.Controls.Add(this.tbTitel);
			this.Controls.Add(this.lbTitel);
			this.Controls.Add(this.tbURL);
			this.Controls.Add(this.lbURL);
			this.Controls.Add(this.lbKategoriRubrik);
			this.Controls.Add(this.lbKategorier);
			this.Controls.Add(this.lvPodcasts);
			this.Controls.Add(this.lbPodcastRubrik);
			this.Name = "Form1";
			this.Text = "The best RRS-reader";
			this.UseWaitCursor = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbPodcastRubrik;
		private System.Windows.Forms.ListView lvPodcasts;
		private System.Windows.Forms.ColumnHeader chAvsnitt;
		private System.Windows.Forms.ColumnHeader chTitel;
		private System.Windows.Forms.ColumnHeader chFrekvens;
		private System.Windows.Forms.ColumnHeader chKategori;
		private System.Windows.Forms.ListBox lbKategorier;
		private System.Windows.Forms.Label lbKategoriRubrik;
		private System.Windows.Forms.Label lbURL;
		private System.Windows.Forms.TextBox tbURL;
		private System.Windows.Forms.Label lbTitel;
		private System.Windows.Forms.TextBox tbTitel;
		private System.Windows.Forms.Label lbFrekvens;
		private System.Windows.Forms.ComboBox cbFrekvens;
		private System.Windows.Forms.Label lbKategori;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox tbKategor;
		private System.Windows.Forms.Button btnNyKategori;
		private System.Windows.Forms.Button btnSparaKategori;
		private System.Windows.Forms.Button btnTaBortKategori;
		private System.Windows.Forms.Button btnNyPodcast;
		private System.Windows.Forms.Button btnSparaPodcast;
		private System.Windows.Forms.Button btnTaBortPodcast;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label lbAntalAvsnitt;
	}
}

