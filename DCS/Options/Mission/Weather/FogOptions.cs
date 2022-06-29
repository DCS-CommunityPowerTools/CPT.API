using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Mission.Weather {

	[DataContract]
	public class FogOptions {

		[DataMember(Name = "thickness")]
		public ushort Thickness { get; set; } = 0;

		[DataMember(Name = "visibility")]
		public ushort Visibility { get; set; } = 0;
	}

}
