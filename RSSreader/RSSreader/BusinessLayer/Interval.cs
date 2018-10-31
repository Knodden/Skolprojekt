using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace RSSreader.BusinessLayer
{
    class Interval
    {
		//private static System.Timers.Timer intervalTimer;
		private static List<int> possibleIntervals = new List<int>(new int[] { 1, 5, 10, 15 });

		public static List<int> PossibleIntervals() { 
			return possibleIntervals;
		}
	}
}
