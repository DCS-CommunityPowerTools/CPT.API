using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Client {

	[DataContract]
	public class DifficultyOptions {

		[DataMember(Name = "fuel")]
		public object fuel { get; set; } = false;

		[DataMember(Name = "easyRadar")]
		public object easyRadar { get; set; } = false;

		[DataMember(Name = "miniHUD")]
		public object miniHUD { get; set; } = false;

		[DataMember(Name = "optionsView")]
		public object optionsView { get; set; } = "optview_all";

		[DataMember(Name = "setGlobal")]
		public object setGlobal { get; set; } = true;

		[DataMember(Name = "avionicsLanguage")]
		public object avionicsLanguage { get; set; } = "english";

		[DataMember(Name = "cockpitVisualRM")]
		public object cockpitVisualRM { get; set; } = true;

		[DataMember(Name = "map")]
		public object map { get; set; } = true;

		[DataMember(Name = "spectatorExternalViews")]
		public object spectatorExternalViews { get; set; } = true;

		[DataMember(Name = "userSnapView")]
		public object userSnapView { get; set; } = true;

		[DataMember(Name = "iconsTheme")]
		public object iconsTheme { get; set; } = "nato";

		[DataMember(Name = "weapons")]
		public object weapons { get; set; } = false;

		[DataMember(Name = "tacticalMap")]
		public object tacticalMap { get; set; } = false;

		[DataMember(Name = "padlock")]
		public object padlock { get; set; } = false;

		[DataMember(Name = "birds")]
		public object birds { get; set; } = 0;

		[DataMember(Name = "permitCrash")]
		public object permitCrash { get; set; } = true;

		[DataMember(Name = "immortal")]
		public object immortal { get; set; } = false;

		[DataMember(Name = "easyCommunication")]
		public object easyCommunication { get; set; } = false;

		[DataMember(Name = "wakeTurbulence")]
		public object wakeTurbulence { get; set; } = true;

		[DataMember(Name = "geffect")]
		public object geffect { get; set; } = "realistic";

		[DataMember(Name = "easyFlight")]
		public object easyFlight { get; set; } = false;

		[DataMember(Name = "hideStick")]
		public object hideStick { get; set; } = false;

		[DataMember(Name = "radio")]
		public object radio { get; set; } = false;

		[DataMember(Name = "reports")]
		public object reports { get; set; } = true;

		[DataMember(Name = "userMarks")]
		public object userMarks { get; set; } = true;

		[DataMember(Name = "units")]
		public object units { get; set; } = "imperial";

		[DataMember(Name = "autoTrimmer")]
		public object autoTrimmer { get; set; } = false;

		[DataMember(Name = "tips")]
		public object tips { get; set; } = false;

		[DataMember(Name = "controlsIndicator")]
		public object controlsIndicator { get; set; } = false;

		[DataMember(Name = "RBDAI")]
		public object RBDAI { get; set; } = false;

		[DataMember(Name = "externalViews")]
		public object externalViews { get; set; } = true;

		[DataMember(Name = "cockpitStatusBarAllowed")]
		public object cockpitStatusBarAllowed { get; set; } = false;

		[DataMember(Name = "compassTape")]
		public object compassTape { get; set; } = true;

		[DataMember(Name = "aircraftMode")]
		public object aircraftMode { get; set; } = true;

		[DataMember(Name = "unrestrictedSATNAV")]
		public object unrestrictedSATNAV { get; set; } = false;

		[DataMember(Name = "labels")]
		public object labels { get; set; } = 3;

	}

}
