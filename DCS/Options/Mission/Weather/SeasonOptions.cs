using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Mission.Weather {

	[DataContract]
	public class SeasonOptions {

		[DataMember(Name = "temperature")]
		public ushort Temperature { get; set; }

	}

}
