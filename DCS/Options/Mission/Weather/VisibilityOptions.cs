using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPT.API.DCS.Options.Mission.Weather {
	
	[DataContract]
	public class VisibilityOptions {

		[DataMember(Name = "distance")]
		public uint Distance { get; set; }

	}
}
