using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSreader.BusinessLayer {
	class Dialog {
		// Tar in en Expectation och skapar en Message.Box
		// Måste kanske inte vara ett expecation..
		internal static void EmptyInput() {
			MessageBox.Show("Can't leave input empty. Please try again.");
		}
		internal static void CatogeryExist() {
			MessageBox.Show("This category does alerady exist");
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
	}
}
