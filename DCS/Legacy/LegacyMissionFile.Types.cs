using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CPT.API.IO.Serialization.DCS.Legacy {

	partial class LegacyMissionFile {

		public struct Date {

			public int Year { get; set; }
			public int Month { get; set; }
			public int Day { get; set; }




			public Date(int year, int month, int day) {
				this.Year = year;
				this.Month = month;
				this.Day = day;
			}

			public Date() : this(2016, 6, 1) { }

		}

	}

}
