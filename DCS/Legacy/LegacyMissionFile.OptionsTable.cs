using CPT.API.DCS.Options.Client;
using System.Runtime.Serialization;




namespace CPT.API.IO.Serialization.DCS.Legacy {

	partial class LegacyMissionFile {

		[DataContract]
		public class OptionsTable : LuaTable {

			[DataMember(Name = "playerName")]
			public string PlayerName { get; set; }

			[DataMember(Name = "miscellaneous")]
			public MiscellaneousOptions Miscellaneous { get; set; }

			[DataMember(Name = "difficulty")]
			public DifficultyOptions Difficulty { get; set; }

			[DataMember(Name = "VR")]
			public VirtualRealityOptions VirtualReality { get; set; }

			[DataMember(Name = "graphics")]
			public GraphicsOptions Graphics { get; set; }

			[DataMember(Name = "format")]
			public int Format { get; set; } = 1;

			[DataMember(Name = "sound")]
			public SoundOptions Sound { get; set; }

			[DataMember(Name = "views")]
			public ViewsOptions Views { get; set; }

		}

	}

}
