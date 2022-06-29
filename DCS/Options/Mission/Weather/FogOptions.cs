using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPT.API.DCS.Options.Mission.Weather {
	
	[DataContract]
	public class FogOptions {

		[DataMember(Name = "thickness")]
		public ushort Thickness { get; set; } = 0;

        [DataMember(Name = "visibility")]
		public ushort Visibility { get; set; } = 0;
	}

}
