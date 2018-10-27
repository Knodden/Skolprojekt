using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSreader.BusinessLayer
{
    class Validate
    {
		public void IsURL(string URL) {
			// Kontrollera att string URL är en länk.
        {
			if (URL.Contains(@"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$"))
            {
                return true;
            }
           else
           {
               return false;
           }
                
        bool NotEmpty(string Input) 
        {
            if(Input == !null) 
            {
                return true;
            }
            else
            {
                return false;
            }
		}
    }
 }
}

}
