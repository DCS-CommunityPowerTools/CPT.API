using System.Runtime.Serialization;




namespace CPT.API.DCS.Options.Client {

	[DataContract]
	public class SoundOptions {

		[DataMember(Name = "main_output")]
		public object main_output { get; set; } = "{0.0.0.00000000}.{2f81c673-7339-44a8-a8e4-6924c160e317}";

		[DataMember(Name = "FakeAfterburner")]
		public object FakeAfterburner { get; set; } = false;

		[DataMember(Name = "volume")]
		public object volume { get; set; } = 75;

		[DataMember(Name = "headphones_on_external_views")]
		public object headphones_on_external_views { get; set; } = true;

		[DataMember(Name = "subtitles")]
		public object subtitles { get; set; } = true;

		[DataMember(Name = "world")]
		public object world { get; set; } = 81;

		[DataMember(Name = "hear_in_helmet")]
		public object hear_in_helmet { get; set; } = true;

		[DataMember(Name = "cockpit")]
		public object cockpit { get; set; } = 85;

		[DataMember(Name = "main_layout")]
		public object main_layout { get; set; } = "";

		[DataMember(Name = "hp_output")]
		public object hp_output { get; set; } = "{0.0.0.00000000}.{2f81c673-7339-44a8-a8e4-6924c160e317}";

		[DataMember(Name = "radioSpeech")]
		public object radioSpeech { get; set; } = true;

		[DataMember(Name = "voice_chat_output")]
		public object voice_chat_output { get; set; } = "0:{0.0.0.00000000}.{2f81c673-7339-44a8-a8e4-6924c160e317}";

		[DataMember(Name = "voice_chat")]
		public object voice_chat { get; set; } = false;

		[DataMember(Name = "microphone_use")]
		public object microphone_use { get; set; } = 2;

		[DataMember(Name = "GBreathEffect")]
		public object GBreathEffect { get; set; } = true;

		[DataMember(Name = "switches")]
		public object switches { get; set; } = 100;

		[DataMember(Name = "play_audio_while_minimized")]
		public object play_audio_while_minimized { get; set; } = false;

		[DataMember(Name = "headphones")]
		public object headphones { get; set; } = 84;

		[DataMember(Name = "music")]
		public object music { get; set; } = 51;

		[DataMember(Name = "voice_chat_input")]
		public object voice_chat_input { get; set; } = "0:{0.0.1.00000000}.{6a78babe-837c-428c-8291-65a67c5db5b8}";

		[DataMember(Name = "gui")]
		public object gui { get; set; } = 76;

	}

}
