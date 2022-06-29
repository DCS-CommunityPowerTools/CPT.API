using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Client {

	[DataContract]
	public class ViewsOptions {

		[DataContract]
		public class CockpitOptions {

			[DataMember(Name = "mirrors")]
			public object mirrors { get; set; } = false;

			[DataMember(Name = "reflections")]
			public object reflections { get; set; } = false;

			[DataMember(Name = "avionics")]
			public object avionics { get; set; } = 4;

		}

		[DataMember(Name = "cockpit")]
		public CockpitOptions Cockpit { get; set; }

	}

}
