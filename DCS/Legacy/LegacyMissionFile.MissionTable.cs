using CPT.API.DCS.Options.Mission;
using CPT.API.DCS.Options.Mission.Weather;
using System.Runtime.Serialization;




namespace CPT.API.IO.Serialization.DCS.Legacy {

	partial class LegacyMissionFile {

		[DataContract]
		public class MissionTable : LuaTable {

			[DataMember(Name = "version")]
			public ushort Version { get; set; } = 20;

			[DataMember(Name = "theatre")]
			public string Theatre { get; set; }

			[DataMember(Name = "date")]
			public Date Date { get; set; } = new Date(2016, 6, 1);

			[DataMember(Name = "requiredModules")]
			public string[] RequiredModules { get; set; }

			[DataMember(Name = "weather")]
			public WeatherOptions Weather { get; set; }

			[DataMember(Name = "map")]
			public MapOptions Map { get; set; }

		}

	}

}

