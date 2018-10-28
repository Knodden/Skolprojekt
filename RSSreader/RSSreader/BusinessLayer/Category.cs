﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSreader.BusinessLayer {
	public class Category {
		public string title { get; set; }
		public Category(string categoryTitle) {
			title = categoryTitle;
		}

        protected Category()
        {
        }
	}
}