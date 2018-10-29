using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSreader.BusinessLayer {
	class ErrorMessage {
		// Tar in en Expectation och skapar en Message.Box
		// Måste kanske inte vara ett expecation..
		public static void CatogeryExist() {
			MessageBox.Show("This category does alerady exist");
		}
	}
}
