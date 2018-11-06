using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSreader.BusinessLayer
{
    class DialogBase
    {
        internal virtual void EmptyInput()
        {
            MessageBox.Show("Can't leave input empty.");
        }
    }
}
