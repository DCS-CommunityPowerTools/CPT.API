using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPT.API.DCS.Options.Mission.Weather {
	
	[DataContract]
	public class SeasonOptions {

		[DataMember(Name = "temperature")]
		public ushort Temperature { get; set; }

	}

}
