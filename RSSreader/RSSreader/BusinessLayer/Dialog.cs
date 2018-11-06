using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSreader.BusinessLayer {
	class Dialog : DialogBase
    {
        internal override void EmptyInput()
        {
            MessageBox.Show("Can't leave input empty. Please try again.");
        }
        internal static void CatogeryExist()
        {
			MessageBox.Show("This category does alerady exist. Please try again.");
		}
		internal static void CategoryAdded()
        {
			MessageBox.Show("Category added!");
		}
		internal static void CategoryUpdated()
        {
			MessageBox.Show("Category Updated");
		}
		internal static void PodcastAdded()
        {
			MessageBox.Show("Podcast added");
		}
		internal static void PodcastExist()
        {
			MessageBox.Show("This podcast does already exist. Please try again");
		}
		internal static void NoChange()
        {
			MessageBox.Show("No change have been done.");
		}
		internal static void NotURL()
        {
			MessageBox.Show("Not an valid URL. Please try again");
		}
		internal static void CategoryUsed()
        {
			MessageBox.Show("This category is in use. Please try again.");
		}
		internal static void PodcastUpdated()
        {
			MessageBox.Show("Podcast updated");
		}
	}
}
