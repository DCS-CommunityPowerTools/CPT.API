using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Mission.Weather {

	[DataContract]
	public class CloudOptions {

		[DataMember(Name = "thickness")]
		public ushort Thickness { get; set; } = 770;

		[DataMember(Name = "density")]
		public ushort Density { get; set; } = 5;

		[DataMember(Name = "preset")]
		public string Preset { get; set; } = "Preset2";

		[DataMember(Name = "base")]
		public ushort Base { get; set; } = 1300;

		[DataMember(Name = "iprecptns")]
		public ushort iprecptns { get; set; } = 0; // what

	}

}
