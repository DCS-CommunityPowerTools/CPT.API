using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPT.API.DCS.Options.Mission.Weather {

	[DataContract]
	public class WindLayerOptions {

		[DataMember(Name = "speed")]
		public object speed { get; set; } = 7;

		[DataMember(Name = "dir")]
		public object dir { get; set; } = 71;

	}

}
