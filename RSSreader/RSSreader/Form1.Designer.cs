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
			this.components = new System.ComponentModel.Container();
			this.lbPodcastRubrik = new System.Windows.Forms.Label();
			this.lvPodcasts = new System.Windows.Forms.ListView();
			this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chEpisodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chInterval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbCategory = new System.Windows.Forms.ListBox();
			this.lbCategoryHeader = new System.Windows.Forms.Label();
			this.lbURL = new System.Windows.Forms.Label();
			this.tbPodcastURL = new System.Windows.Forms.TextBox();
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
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbEpisodeAmount = new System.Windows.Forms.Label();
			this.btnRemoveCategory = new System.Windows.Forms.Button();
			this.lbEpisodeDescriptionHeader = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbFilter = new System.Windows.Forms.Label();
			this.lbEpisodeTitle = new System.Windows.Forms.Label();
			this.tbEpsiodeDescription = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lbPodcastRubrik
			// 
			this.lbPodcastRubrik.AutoSize = true;
			this.lbPodcastRubrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPodcastRubrik.Location = new System.Drawing.Point(9, 7);
			this.lbPodcastRubrik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbPodcastRubrik.Name = "lbPodcastRubrik";
			this.lbPodcastRubrik.Size = new System.Drawing.Size(59, 13);
			this.lbPodcastRubrik.TabIndex = 1;
			this.lbPodcastRubrik.Text = "Podcasts";
			// 
			// lvPodcasts
			// 
			this.lvPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chEpisodes,
            this.chInterval,
            this.chCategory});
			this.lvPodcasts.FullRowSelect = true;
			this.lvPodcasts.Location = new System.Drawing.Point(13, 22);
			this.lvPodcasts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lvPodcasts.MultiSelect = false;
			this.lvPodcasts.Name = "lvPodcasts";
			this.lvPodcasts.Size = new System.Drawing.Size(420, 131);
			this.lvPodcasts.TabIndex = 2;
			this.lvPodcasts.UseCompatibleStateImageBehavior = false;
			this.lvPodcasts.View = System.Windows.Forms.View.Details;
			this.lvPodcasts.SelectedIndexChanged += new System.EventHandler(this.lvPodcasts_SelectedIndexChanged);
			// 
			// chTitle
			// 
			this.chTitle.Text = "Title";
			this.chTitle.Width = 185;
			// 
			// chEpisodes
			// 
			this.chEpisodes.Text = "Episodes";
			this.chEpisodes.Width = 71;
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
			this.lbCategory.Location = new System.Drawing.Point(476, 24);
			this.lbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lbCategory.Name = "lbCategory";
			this.lbCategory.Size = new System.Drawing.Size(187, 108);
			this.lbCategory.TabIndex = 3;
			this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// lbCategoryHeader
			// 
			this.lbCategoryHeader.AutoSize = true;
			this.lbCategoryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCategoryHeader.Location = new System.Drawing.Point(474, 8);
			this.lbCategoryHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbCategoryHeader.Name = "lbCategoryHeader";
			this.lbCategoryHeader.Size = new System.Drawing.Size(57, 13);
			this.lbCategoryHeader.TabIndex = 4;
			this.lbCategoryHeader.Text = "Category";
			// 
			// lbURL
			// 
			this.lbURL.AutoSize = true;
			this.lbURL.Location = new System.Drawing.Point(10, 162);
			this.lbURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbURL.Name = "lbURL";
			this.lbURL.Size = new System.Drawing.Size(29, 13);
			this.lbURL.TabIndex = 5;
			this.lbURL.Text = "URL";
			// 
			// tbPodcastURL
			// 
			this.tbPodcastURL.AllowDrop = true;
			this.tbPodcastURL.Location = new System.Drawing.Point(12, 180);
			this.tbPodcastURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbPodcastURL.Name = "tbPodcastURL";
			this.tbPodcastURL.Size = new System.Drawing.Size(114, 20);
			this.tbPodcastURL.TabIndex = 6;
			// 
			// lbPodcastTitle
			// 
			this.lbPodcastTitle.AutoSize = true;
			this.lbPodcastTitle.Location = new System.Drawing.Point(130, 163);
			this.lbPodcastTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbPodcastTitle.Name = "lbPodcastTitle";
			this.lbPodcastTitle.Size = new System.Drawing.Size(27, 13);
			this.lbPodcastTitle.TabIndex = 7;
			this.lbPodcastTitle.Text = "Title";
			// 
			// tbPodcastTitle
			// 
			this.tbPodcastTitle.AllowDrop = true;
			this.tbPodcastTitle.Location = new System.Drawing.Point(132, 180);
			this.tbPodcastTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbPodcastTitle.Name = "tbPodcastTitle";
			this.tbPodcastTitle.Size = new System.Drawing.Size(103, 20);
			this.tbPodcastTitle.TabIndex = 8;
			// 
			// lbPodcastInterval
			// 
			this.lbPodcastInterval.AutoSize = true;
			this.lbPodcastInterval.Location = new System.Drawing.Point(239, 163);
			this.lbPodcastInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbPodcastInterval.Name = "lbPodcastInterval";
			this.lbPodcastInterval.Size = new System.Drawing.Size(42, 13);
			this.lbPodcastInterval.TabIndex = 9;
			this.lbPodcastInterval.Text = "Interval";
			// 
			// cbPodcastInterval
			// 
			this.cbPodcastInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPodcastInterval.FormattingEnabled = true;
			this.cbPodcastInterval.Location = new System.Drawing.Point(242, 180);
			this.cbPodcastInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbPodcastInterval.Name = "cbPodcastInterval";
			this.cbPodcastInterval.Size = new System.Drawing.Size(92, 21);
			this.cbPodcastInterval.TabIndex = 10;
			// 
			// lbPodcastCategory
			// 
			this.lbPodcastCategory.AutoSize = true;
			this.lbPodcastCategory.Location = new System.Drawing.Point(338, 163);
			this.lbPodcastCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbPodcastCategory.Name = "lbPodcastCategory";
			this.lbPodcastCategory.Size = new System.Drawing.Size(49, 13);
			this.lbPodcastCategory.TabIndex = 11;
			this.lbPodcastCategory.Text = "Category";
			// 
			// cbPodcastCategory
			// 
			this.cbPodcastCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPodcastCategory.FormattingEnabled = true;
			this.cbPodcastCategory.Location = new System.Drawing.Point(340, 180);
			this.cbPodcastCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbPodcastCategory.Name = "cbPodcastCategory";
			this.cbPodcastCategory.Size = new System.Drawing.Size(92, 21);
			this.cbPodcastCategory.TabIndex = 12;
			// 
			// tbCategory
			// 
			this.tbCategory.Location = new System.Drawing.Point(476, 136);
			this.tbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbCategory.Name = "tbCategory";
			this.tbCategory.Size = new System.Drawing.Size(187, 20);
			this.tbCategory.TabIndex = 13;
			this.tbCategory.TextChanged += new System.EventHandler(this.tbCategory_TextChanged);
			// 
			// btnNewCategory
			// 
			this.btnNewCategory.Enabled = false;
			this.btnNewCategory.Location = new System.Drawing.Point(476, 159);
			this.btnNewCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnNewCategory.Name = "btnNewCategory";
			this.btnNewCategory.Size = new System.Drawing.Size(91, 19);
			this.btnNewCategory.TabIndex = 14;
			this.btnNewCategory.Text = "New";
			this.btnNewCategory.UseVisualStyleBackColor = true;
			this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
			// 
			// btnSaveCategory
			// 
			this.btnSaveCategory.Enabled = false;
			this.btnSaveCategory.Location = new System.Drawing.Point(572, 159);
			this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSaveCategory.Name = "btnSaveCategory";
			this.btnSaveCategory.Size = new System.Drawing.Size(91, 19);
			this.btnSaveCategory.TabIndex = 15;
			this.btnSaveCategory.Text = "Save";
			this.btnSaveCategory.UseVisualStyleBackColor = true;
			this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
			// 
			// btnNewPodcast
			// 
			this.btnNewPodcast.Location = new System.Drawing.Point(143, 206);
			this.btnNewPodcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnNewPodcast.Name = "btnNewPodcast";
			this.btnNewPodcast.Size = new System.Drawing.Size(91, 19);
			this.btnNewPodcast.TabIndex = 17;
			this.btnNewPodcast.Text = "New";
			this.btnNewPodcast.UseVisualStyleBackColor = true;
			this.btnNewPodcast.Click += new System.EventHandler(this.btnNewPodcast_Click);
			// 
			// btnSavePodcast
			// 
			this.btnSavePodcast.Enabled = false;
			this.btnSavePodcast.Location = new System.Drawing.Point(242, 206);
			this.btnSavePodcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSavePodcast.Name = "btnSavePodcast";
			this.btnSavePodcast.Size = new System.Drawing.Size(91, 19);
			this.btnSavePodcast.TabIndex = 18;
			this.btnSavePodcast.Text = "Save";
			this.btnSavePodcast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSavePodcast.UseVisualStyleBackColor = true;
			this.btnSavePodcast.Click += new System.EventHandler(this.btnSavePodcast_Click);
			// 
			// btnRemovePodcast
			// 
			this.btnRemovePodcast.Enabled = false;
			this.btnRemovePodcast.Location = new System.Drawing.Point(340, 206);
			this.btnRemovePodcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRemovePodcast.Name = "btnRemovePodcast";
			this.btnRemovePodcast.Size = new System.Drawing.Size(91, 19);
			this.btnRemovePodcast.TabIndex = 19;
			this.btnRemovePodcast.Text = "Remove";
			this.btnRemovePodcast.UseVisualStyleBackColor = true;
			this.btnRemovePodcast.Click += new System.EventHandler(this.btnRemovePodcast_Click);
			// 
			// lvEpisodes
			// 
			this.lvEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lvEpisodes.Location = new System.Drawing.Point(12, 249);
			this.lvEpisodes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lvEpisodes.Name = "lvEpisodes";
			this.lvEpisodes.Size = new System.Drawing.Size(294, 106);
			this.lvEpisodes.TabIndex = 20;
			this.lvEpisodes.UseCompatibleStateImageBehavior = false;
			this.lvEpisodes.View = System.Windows.Forms.View.Details;
			this.lvEpisodes.SelectedIndexChanged += new System.EventHandler(this.lvEpisodes_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Title";
			this.columnHeader1.Width = 132;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PubDate";
			this.columnHeader2.Width = 152;
			// 
			// lbEpisodeAmount
			// 
			this.lbEpisodeAmount.AutoSize = true;
			this.lbEpisodeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEpisodeAmount.Location = new System.Drawing.Point(10, 233);
			this.lbEpisodeAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbEpisodeAmount.Name = "lbEpisodeAmount";
			this.lbEpisodeAmount.Size = new System.Drawing.Size(58, 13);
			this.lbEpisodeAmount.TabIndex = 21;
			this.lbEpisodeAmount.Text = "Episodes";
			// 
			// btnRemoveCategory
			// 
			this.btnRemoveCategory.Enabled = false;
			this.btnRemoveCategory.Location = new System.Drawing.Point(476, 180);
			this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRemoveCategory.Name = "btnRemoveCategory";
			this.btnRemoveCategory.Size = new System.Drawing.Size(186, 19);
			this.btnRemoveCategory.TabIndex = 22;
			this.btnRemoveCategory.Text = "Remove";
			this.btnRemoveCategory.UseVisualStyleBackColor = true;
			this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
			// 
			// lbEpisodeDescriptionHeader
			// 
			this.lbEpisodeDescriptionHeader.AutoSize = true;
			this.lbEpisodeDescriptionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEpisodeDescriptionHeader.Location = new System.Drawing.Point(343, 230);
			this.lbEpisodeDescriptionHeader.Name = "lbEpisodeDescriptionHeader";
			this.lbEpisodeDescriptionHeader.Size = new System.Drawing.Size(71, 13);
			this.lbEpisodeDescriptionHeader.TabIndex = 24;
			this.lbEpisodeDescriptionHeader.Text = "Description";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 60000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbFilter
			// 
			this.lbFilter.AutoSize = true;
			this.lbFilter.Location = new System.Drawing.Point(69, 7);
			this.lbFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbFilter.Name = "lbFilter";
			this.lbFilter.Size = new System.Drawing.Size(101, 13);
			this.lbFilter.TabIndex = 26;
			this.lbFilter.Text = "Filter by Category (*)";
			// 
			// lbEpisodeTitle
			// 
			this.lbEpisodeTitle.AutoSize = true;
			this.lbEpisodeTitle.Location = new System.Drawing.Point(345, 247);
			this.lbEpisodeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbEpisodeTitle.Name = "lbEpisodeTitle";
			this.lbEpisodeTitle.Size = new System.Drawing.Size(27, 13);
			this.lbEpisodeTitle.TabIndex = 27;
			this.lbEpisodeTitle.Text = "Title";
			// 
			// tbEpsiodeDescription
			// 
			this.tbEpsiodeDescription.BackColor = System.Drawing.SystemColors.Window;
			this.tbEpsiodeDescription.Location = new System.Drawing.Point(347, 264);
			this.tbEpsiodeDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbEpsiodeDescription.Name = "tbEpsiodeDescription";
			this.tbEpsiodeDescription.ReadOnly = true;
			this.tbEpsiodeDescription.Size = new System.Drawing.Size(316, 91);
			this.tbEpsiodeDescription.TabIndex = 28;
			this.tbEpsiodeDescription.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 366);
			this.Controls.Add(this.tbEpsiodeDescription);
			this.Controls.Add(this.lbEpisodeTitle);
			this.Controls.Add(this.lbFilter);
			this.Controls.Add(this.lbEpisodeDescriptionHeader);
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
			this.Controls.Add(this.tbPodcastURL);
			this.Controls.Add(this.lbURL);
			this.Controls.Add(this.lbCategoryHeader);
			this.Controls.Add(this.lbCategory);
			this.Controls.Add(this.lvPodcasts);
			this.Controls.Add(this.lbPodcastRubrik);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "The best RRS-reader";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbPodcastRubrik;
		private System.Windows.Forms.ListView lvPodcasts;
		private System.Windows.Forms.ColumnHeader chTitle;
		private System.Windows.Forms.ColumnHeader chInterval;
		private System.Windows.Forms.ColumnHeader chCategory;
		private System.Windows.Forms.ListBox lbCategory;
		private System.Windows.Forms.Label lbCategoryHeader;
		private System.Windows.Forms.Label lbURL;
		private System.Windows.Forms.TextBox tbPodcastURL;
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
        private System.Windows.Forms.ColumnHeader chEpisodes;
        private System.Windows.Forms.Label lbEpisodeDescriptionHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbFilter;
		private System.Windows.Forms.Label lbEpisodeTitle;
		private System.Windows.Forms.RichTextBox tbEpsiodeDescription;
	}
}

