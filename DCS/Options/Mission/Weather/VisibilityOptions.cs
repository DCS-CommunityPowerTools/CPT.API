using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Mission.Weather {

	[DataContract]
	public class VisibilityOptions {

		[DataMember(Name = "distance")]
		public uint Distance { get; set; }

	}
}
