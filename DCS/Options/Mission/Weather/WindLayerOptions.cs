using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Mission.Weather {

	[DataContract]
	public class WindLayerOptions {

		[DataMember(Name = "speed")]
		public object speed { get; set; } = 7;

		[DataMember(Name = "dir")]
		public object dir { get; set; } = 71;

	}

}
