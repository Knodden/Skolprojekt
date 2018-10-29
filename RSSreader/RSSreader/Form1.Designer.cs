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
			this.chEpisodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chInterval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbCategory = new System.Windows.Forms.ListBox();
			this.lbCategoryHeader = new System.Windows.Forms.Label();
			this.lbURL = new System.Windows.Forms.Label();
			this.tbURL = new System.Windows.Forms.TextBox();
			this.lbPodcastTitle = new System.Windows.Forms.Label();
			this.tbPodcastTitle = new System.Windows.Forms.TextBox();
			this.lbPodcastInterval = new System.Windows.Forms.Label();
			this.cbPodcastInterval = new System.Windows.Forms.ComboBox();
			this.lbPodcastCategory = new System.Windows.Forms.Label();
			this.cbPodcastCategory = new System.Windows.Forms.ComboBox();
			this.tbCategory = new System.Windows.Forms.TextBox();
			this.btnNewCategory = new System.Windows.Forms.Button();
			this.btnSaveCategory = new System.Windows.Forms.Button();
			this.btnNewPodcast = new System.Windows.Forms.Button();
			this.btnSavePodcast = new System.Windows.Forms.Button();
			this.btnRemovePodcast = new System.Windows.Forms.Button();
			this.lvEpisodes = new System.Windows.Forms.ListView();
			this.lbEpisodeAmount = new System.Windows.Forms.Label();
			this.btnRemoveCategory = new System.Windows.Forms.Button();
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
            this.chEpisodes,
            this.chTitle,
            this.chInterval,
            this.chCategory});
			this.lvPodcasts.Location = new System.Drawing.Point(15, 30);
			this.lvPodcasts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lvPodcasts.Name = "lvPodcasts";
			this.lvPodcasts.Size = new System.Drawing.Size(559, 160);
			this.lvPodcasts.TabIndex = 2;
			this.lvPodcasts.UseCompatibleStateImageBehavior = false;
			this.lvPodcasts.UseWaitCursor = true;
			this.lvPodcasts.View = System.Windows.Forms.View.Details;
			// 
			// chEpisodes
			// 
			this.chEpisodes.Text = "Episodes";
			this.chEpisodes.Width = 77;
			// 
			// chTitle
			// 
			this.chTitle.Text = "Title";
			this.chTitle.Width = 185;
			// 
			// chInterval
			// 
			this.chInterval.Text = "Interval";
			this.chInterval.Width = 71;
			// 
			// chCategory
			// 
			this.chCategory.Text = "Category";
			this.chCategory.Width = 100;
			// 
			// lbCategory
			// 
			this.lbCategory.FormattingEnabled = true;
			this.lbCategory.ItemHeight = 16;
			this.lbCategory.Location = new System.Drawing.Point(635, 30);
			this.lbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lbCategory.Name = "lbCategory";
			this.lbCategory.Size = new System.Drawing.Size(248, 132);
			this.lbCategory.TabIndex = 3;
			this.lbCategory.UseWaitCursor = true;
			this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// lbCategoryHeader
			// 
			this.lbCategoryHeader.AutoSize = true;
			this.lbCategoryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCategoryHeader.Location = new System.Drawing.Point(632, 10);
			this.lbCategoryHeader.Name = "lbCategoryHeader";
			this.lbCategoryHeader.Size = new System.Drawing.Size(73, 17);
			this.lbCategoryHeader.TabIndex = 4;
			this.lbCategoryHeader.Text = "Category";
			this.lbCategoryHeader.UseWaitCursor = true;
			// 
			// lbURL
			// 
			this.lbURL.AutoSize = true;
			this.lbURL.Location = new System.Drawing.Point(13, 199);
			this.lbURL.Name = "lbURL";
			this.lbURL.Size = new System.Drawing.Size(36, 17);
			this.lbURL.TabIndex = 5;
			this.lbURL.Text = "URL";
			this.lbURL.UseWaitCursor = true;
			// 
			// tbURL
			// 
			this.tbURL.AllowDrop = true;
			this.tbURL.Location = new System.Drawing.Point(16, 222);
			this.tbURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbURL.Name = "tbURL";
			this.tbURL.Size = new System.Drawing.Size(151, 22);
			this.tbURL.TabIndex = 6;
			this.tbURL.UseWaitCursor = true;
			this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
			// 
			// lbPodcastTitle
			// 
			this.lbPodcastTitle.AutoSize = true;
			this.lbPodcastTitle.Location = new System.Drawing.Point(173, 201);
			this.lbPodcastTitle.Name = "lbPodcastTitle";
			this.lbPodcastTitle.Size = new System.Drawing.Size(35, 17);
			this.lbPodcastTitle.TabIndex = 7;
			this.lbPodcastTitle.Text = "Title";
			this.lbPodcastTitle.UseWaitCursor = true;
			// 
			// tbPodcastTitle
			// 
			this.tbPodcastTitle.AllowDrop = true;
			this.tbPodcastTitle.Location = new System.Drawing.Point(176, 222);
			this.tbPodcastTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPodcastTitle.Name = "tbPodcastTitle";
			this.tbPodcastTitle.Size = new System.Drawing.Size(136, 22);
			this.tbPodcastTitle.TabIndex = 8;
			this.tbPodcastTitle.UseWaitCursor = true;
			// 
			// lbPodcastInterval
			// 
			this.lbPodcastInterval.AutoSize = true;
			this.lbPodcastInterval.Location = new System.Drawing.Point(319, 201);
			this.lbPodcastInterval.Name = "lbPodcastInterval";
			this.lbPodcastInterval.Size = new System.Drawing.Size(54, 17);
			this.lbPodcastInterval.TabIndex = 9;
			this.lbPodcastInterval.Text = "Interval";
			this.lbPodcastInterval.UseWaitCursor = true;
			// 
			// cbPodcastInterval
			// 
			this.cbPodcastInterval.FormattingEnabled = true;
			this.cbPodcastInterval.Location = new System.Drawing.Point(323, 222);
			this.cbPodcastInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbPodcastInterval.Name = "cbPodcastInterval";
			this.cbPodcastInterval.Size = new System.Drawing.Size(121, 24);
			this.cbPodcastInterval.TabIndex = 10;
			this.cbPodcastInterval.UseWaitCursor = true;
			// 
			// lbPodcastCategory
			// 
			this.lbPodcastCategory.AutoSize = true;
			this.lbPodcastCategory.Location = new System.Drawing.Point(451, 201);
			this.lbPodcastCategory.Name = "lbPodcastCategory";
			this.lbPodcastCategory.Size = new System.Drawing.Size(65, 17);
			this.lbPodcastCategory.TabIndex = 11;
			this.lbPodcastCategory.Text = "Category";
			this.lbPodcastCategory.UseWaitCursor = true;
			// 
			// cbPodcastCategory
			// 
			this.cbPodcastCategory.FormattingEnabled = true;
			this.cbPodcastCategory.Location = new System.Drawing.Point(453, 222);
			this.cbPodcastCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbPodcastCategory.Name = "cbPodcastCategory";
			this.cbPodcastCategory.Size = new System.Drawing.Size(121, 24);
			this.cbPodcastCategory.TabIndex = 12;
			this.cbPodcastCategory.UseWaitCursor = true;
			// 
			// tbCategory
			// 
			this.tbCategory.Location = new System.Drawing.Point(635, 167);
			this.tbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbCategory.Name = "tbCategory";
			this.tbCategory.Size = new System.Drawing.Size(248, 22);
			this.tbCategory.TabIndex = 13;
			this.tbCategory.UseWaitCursor = true;
			// 
			// btnNewCategory
			// 
			this.btnNewCategory.Location = new System.Drawing.Point(635, 196);
			this.btnNewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNewCategory.Name = "btnNewCategory";
			this.btnNewCategory.Size = new System.Drawing.Size(121, 23);
			this.btnNewCategory.TabIndex = 14;
			this.btnNewCategory.Text = "New";
			this.btnNewCategory.UseVisualStyleBackColor = true;
			this.btnNewCategory.UseWaitCursor = true;
			this.btnNewCategory.Click += new System.EventHandler(this.btnNyKategori_Click);
			// 
			// btnSaveCategory
			// 
			this.btnSaveCategory.Enabled = false;
			this.btnSaveCategory.Location = new System.Drawing.Point(763, 196);
			this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSaveCategory.Name = "btnSaveCategory";
			this.btnSaveCategory.Size = new System.Drawing.Size(121, 23);
			this.btnSaveCategory.TabIndex = 15;
			this.btnSaveCategory.Text = "Save";
			this.btnSaveCategory.UseVisualStyleBackColor = true;
			this.btnSaveCategory.UseWaitCursor = true;
			this.btnSaveCategory.Click += new System.EventHandler(this.btnSparaKategori_Click);
			// 
			// btnNewPodcast
			// 
			this.btnNewPodcast.Location = new System.Drawing.Point(191, 254);
			this.btnNewPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNewPodcast.Name = "btnNewPodcast";
			this.btnNewPodcast.Size = new System.Drawing.Size(121, 23);
			this.btnNewPodcast.TabIndex = 17;
			this.btnNewPodcast.Text = "New";
			this.btnNewPodcast.UseVisualStyleBackColor = true;
			this.btnNewPodcast.UseWaitCursor = true;
			this.btnNewPodcast.Click += new System.EventHandler(this.btnNyPodcast_Click);
			// 
			// btnSavePodcast
			// 
			this.btnSavePodcast.Location = new System.Drawing.Point(323, 254);
			this.btnSavePodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSavePodcast.Name = "btnSavePodcast";
			this.btnSavePodcast.Size = new System.Drawing.Size(121, 23);
			this.btnSavePodcast.TabIndex = 18;
			this.btnSavePodcast.Text = "Save";
			this.btnSavePodcast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSavePodcast.UseVisualStyleBackColor = true;
			this.btnSavePodcast.UseWaitCursor = true;
			this.btnSavePodcast.Click += new System.EventHandler(this.btnSparaPodcast_Click);
			// 
			// btnRemovePodcast
			// 
			this.btnRemovePodcast.Location = new System.Drawing.Point(453, 254);
			this.btnRemovePodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRemovePodcast.Name = "btnRemovePodcast";
			this.btnRemovePodcast.Size = new System.Drawing.Size(121, 23);
			this.btnRemovePodcast.TabIndex = 19;
			this.btnRemovePodcast.Text = "Remove";
			this.btnRemovePodcast.UseVisualStyleBackColor = true;
			this.btnRemovePodcast.UseWaitCursor = true;
			this.btnRemovePodcast.Click += new System.EventHandler(this.btnTaBortPodcast_Click);
			// 
			// lvEpisodes
			// 
			this.lvEpisodes.Location = new System.Drawing.Point(16, 306);
			this.lvEpisodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lvEpisodes.Name = "lvEpisodes";
			this.lvEpisodes.Size = new System.Drawing.Size(296, 112);
			this.lvEpisodes.TabIndex = 20;
			this.lvEpisodes.UseCompatibleStateImageBehavior = false;
			this.lvEpisodes.UseWaitCursor = true;
			// 
			// lbEpisodeAmount
			// 
			this.lbEpisodeAmount.AutoSize = true;
			this.lbEpisodeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEpisodeAmount.Location = new System.Drawing.Point(13, 287);
			this.lbEpisodeAmount.Name = "lbEpisodeAmount";
			this.lbEpisodeAmount.Size = new System.Drawing.Size(74, 17);
			this.lbEpisodeAmount.TabIndex = 21;
			this.lbEpisodeAmount.Text = "Episodes";
			this.lbEpisodeAmount.UseWaitCursor = true;
			// 
			// btnRemoveCategory
			// 
			this.btnRemoveCategory.Enabled = false;
			this.btnRemoveCategory.Location = new System.Drawing.Point(635, 222);
			this.btnRemoveCategory.Name = "btnRemoveCategory";
			this.btnRemoveCategory.Size = new System.Drawing.Size(248, 23);
			this.btnRemoveCategory.TabIndex = 22;
			this.btnRemoveCategory.Text = "Remove";
			this.btnRemoveCategory.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(901, 450);
			this.Controls.Add(this.btnRemoveCategory);
			this.Controls.Add(this.lbEpisodeAmount);
			this.Controls.Add(this.lvEpisodes);
			this.Controls.Add(this.btnRemovePodcast);
			this.Controls.Add(this.btnSavePodcast);
			this.Controls.Add(this.btnNewPodcast);
			this.Controls.Add(this.btnSaveCategory);
			this.Controls.Add(this.btnNewCategory);
			this.Controls.Add(this.tbCategory);
			this.Controls.Add(this.cbPodcastCategory);
			this.Controls.Add(this.lbPodcastCategory);
			this.Controls.Add(this.cbPodcastInterval);
			this.Controls.Add(this.lbPodcastInterval);
			this.Controls.Add(this.tbPodcastTitle);
			this.Controls.Add(this.lbPodcastTitle);
			this.Controls.Add(this.tbURL);
			this.Controls.Add(this.lbURL);
			this.Controls.Add(this.lbCategoryHeader);
			this.Controls.Add(this.lbCategory);
			this.Controls.Add(this.lvPodcasts);
			this.Controls.Add(this.lbPodcastRubrik);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
		private System.Windows.Forms.ColumnHeader chEpisodes;
		private System.Windows.Forms.ColumnHeader chTitle;
		private System.Windows.Forms.ColumnHeader chInterval;
		private System.Windows.Forms.ColumnHeader chCategory;
		private System.Windows.Forms.ListBox lbCategory;
		private System.Windows.Forms.Label lbCategoryHeader;
		private System.Windows.Forms.Label lbURL;
		private System.Windows.Forms.TextBox tbURL;
		private System.Windows.Forms.Label lbPodcastTitle;
		private System.Windows.Forms.TextBox tbPodcastTitle;
		private System.Windows.Forms.Label lbPodcastInterval;
		private System.Windows.Forms.ComboBox cbPodcastInterval;
		private System.Windows.Forms.Label lbPodcastCategory;
		private System.Windows.Forms.ComboBox cbPodcastCategory;
		private System.Windows.Forms.TextBox tbCategory;
		private System.Windows.Forms.Button btnNewCategory;
		private System.Windows.Forms.Button btnSaveCategory;
		private System.Windows.Forms.Button btnNewPodcast;
		private System.Windows.Forms.Button btnSavePodcast;
		private System.Windows.Forms.Button btnRemovePodcast;
		private System.Windows.Forms.ListView lvEpisodes;
		private System.Windows.Forms.Label lbEpisodeAmount;
		private System.Windows.Forms.Button btnRemoveCategory;
	}
}

