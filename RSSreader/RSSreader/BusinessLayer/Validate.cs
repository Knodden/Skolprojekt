using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RSSreader.BusinessLayer
{
    class Validate
    {
		public bool IsURL(string URL) {
			// Kontrollera att string URL är en länk.
			{
				if (URL.Contains(@"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$")) {
					return true;
				}
				else {
					return false;
				}
			}
		}
        public bool NotEmpty(string input) { 
            if(string.IsNullOrEmpty(input)) 
            {
                return false;
            }
            else
            {
                return true;
            }
		}
    }
}
