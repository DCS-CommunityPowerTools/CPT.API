using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPT.API.DCS.Options.Mission {
	
	[DataContract]
	public class MapOptions {

		[DataMember(Name = "centerX")]
		public double CenterX { get; set; }

		[DataMember(Name = "centerY")]
		public double CenterY { get; set; }

		[DataMember(Name = "zoom")]
		public float Zoom { get; set; }

	}

}
