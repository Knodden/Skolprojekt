using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSreader.BusinessLayer {
	class Dialog {
		internal static void EmptyInput() {
			MessageBox.Show("Can't leave input empty. Please try again.");
		}
		internal static void CatogeryExist() {
			MessageBox.Show("This category does aleready exist. Please try again.");
		}
		internal static void CatogeryNotExist() {
			MessageBox.Show("This category doesn't exist. Please try again");
		}
		internal static void CategoryAdded() {
			MessageBox.Show("Category added!");
		}
		internal static void CategoryRemoved() {
			MessageBox.Show("Category removed");
		}
		internal static void CategoryUpdated() {
			MessageBox.Show("Category Updated");
		}
		internal static void NoChange() {
			MessageBox.Show("No change have been done.");
		}
        internal static void UrlExists()
        {
            MessageBox.Show("This Url already exists. Please try again");
        }
	}
}
