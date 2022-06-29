using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Mission.Weather {

	public class WeatherOptions {

		[DataMember(Name = "name_ru")]
		public object name_ru { get; set; } = "Лето. Oблачность и ветер";

		[DataMember(Name = "name_de")]
		public object name_de { get; set; } = "Sommer, Wind und Wolken";

		[DataMember(Name = "name_fr")]
		public object name_fr { get; set; } = "Eté, nuages et vent";

		[DataMember(Name = "name")]
		public object name { get; set; } = "Summer. Clouds & wind";

		[DataMember(Name = "name_es")]
		public object name_es { get; set; } = "Verano. Nubes y viento";

		[DataMember(Name = "name_cn")]
		public object name_cn { get; set; } = "夏季 多云+有风";




		[DataMember(Name = "enable_fog")]
		public bool FogEnabled { get; set; } = false;

		[DataMember(Name = "qnh")]
		public ushort qnh { get; set; } = 755;

		[DataMember(Name = "dust_density")]
		public ushort dust_density { get; set; } = 0;

		[DataMember(Name = "enable_dust")]
		public bool DustEnabled { get; set; } = false;

		[DataMember(Name = "atmosphere_type")]
		public ushort atmosphere_type { get; set; } = 0;

		[DataMember(Name = "groundTurbulence")]
		public ushort Turbulence { get; set; } = 12;

		[DataMember(Name = "type_weather")]
		public ushort type_weather { get; set; } = 0;

		[DataMember(Name = "modifiedTime")]
		public bool ModifiedTime { get; set; } = false;




		[DataMember(Name = "wind")]
		public WindOptions Wind { get; set; }

		[DataMember(Name = "season")]
		public SeasonOptions Season { get; set; }

		[DataMember(Name = "visibility")]
		public VisibilityOptions Visibility { get; set; }

		[DataMember(Name = "clouds")]
		public CloudOptions Clouds { get; set; }

		[DataMember(Name = "fog")]
		public FogOptions Fog { get; set; }

		/*["cyclones"] =
        {
        },*/

	}

}
