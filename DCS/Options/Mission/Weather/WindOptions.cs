using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Mission.Weather {

	[DataContract]
	public class WindOptions {

		[DataContract]
		public class Layer {

			[DataMember(Name = "speed")]
			public ushort Speed { get; set; } = 7;

			[DataMember(Name = "dir")]
			public ushort Direction { get; set; } = 71;

		}

		[DataMember(Name = "at8000")]
		public Layer At8000 { get; set; }

		[DataMember(Name = "at2000")]
		public Layer At2000 { get; set; }

		[DataMember(Name = "atGround")]
		public Layer AtGround { get; set; }

	}

}
