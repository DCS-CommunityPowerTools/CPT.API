using System.ComponentModel;
using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Client {

	[DataContract]
	public class MiscellaneousOptions {

		[DisplayName("Allow server screenshots")]
		[DataMember(Name = "allow_server_screenshots")]
		public bool AllowServerScreenshots { get; set; } = false;

		[DisplayName("Head move")]
		[DataMember(Name = "headmove")]
		public bool HeadMove { get; set; } = false;

		[DisplayName("TrackIR in external views")]
		[DataMember(Name = "TrackIR_external_views")]
		public bool ExternalViewsTrackIR { get; set; } = true;

		[DisplayName("Nearest aircraft tracking (F5)")]
		[DataMember(Name = "f5_nearest_ac")]
		public bool NearestAircraft { get; set; } = true;

		[DisplayName("Free camera (F11)")]
		[DataMember(Name = "f11_free_camera")]
		public bool FreeCamera { get; set; } = true;

		[DisplayName("View effects (F2)")]
		[DataMember(Name = "F2_view_effects")]
		public F2ViewEffects F2ViewEffects { get; set; } = F2ViewEffects.Floating;

		[DisplayName("Awacs (F10)")] // TODO: figure out what exactly this setting does
		[DataMember(Name = "f10_awacs")]
		public bool Awacs { get; set; } = true;

		[DisplayName("Coordinate display format")]
		[DataMember(Name = "Coordinate_Display")]
		public CoordinateDisplayFormat CoordinateDisplayFormat { get; set; } = CoordinateDisplayFormat.LatLong;

		[DisplayName("Accidental failures")] // TODO: is this random failures?
		[DataMember(Name = "accidental_failures")]
		public bool AccidentalFailures { get; set; } = false;

		[DisplayName("Automatic login")]
		[DataMember(Name = "autologin")]
		public bool Autologin { get; set; } = true;

		[DisplayName("Force feedback")]
		[DataMember(Name = "force_feedback_enabled")]
		public bool ForceFeedbackEnabled { get; set; } = true;

		[DisplayName("Collect statistics (telemetry)")]
		[DataMember(Name = "collect_stat")]
		public bool CollectStat { get; set; } = false;

		[DisplayName("Chat window at start")]
		[DataMember(Name = "chat_window_at_start")]
		public bool ChatWindowAtStart { get; set; } = false;

		[DisplayName("Synchronize controls")]
		[DataMember(Name = "synchronize_controls")]
		public bool SynchronizeControls { get; set; } = false;

		[DisplayName("Show pilot body")]
		[DataMember(Name = "show_pilot_body")]
		public bool ShowPilotBody { get; set; } = false;

	}

}
