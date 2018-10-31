using RSSreader.BusinessLayer;
using RSSreader.DataAcessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSreader {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
            //List<Podcast> podcasts = new List<Podcast> { new Podcast() { Title = "Berras äventyr" } };
            //new FileHandler().SavePodcasts(podcasts);
            //var l = new FileHandler().LoadPodcasts();


            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
