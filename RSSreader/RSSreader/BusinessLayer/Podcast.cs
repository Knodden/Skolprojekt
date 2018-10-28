using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSreader.BusinessLayer
{
    public class Podcast
    {
		public string Title { get; set; }	
		public string Url { get; set; }
		public int Episodes { get; set; }
		public int UpdateInterval { get; set; }
	}
}

