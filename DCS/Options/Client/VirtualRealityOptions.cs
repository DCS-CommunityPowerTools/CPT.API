using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPT.API.DCS.Options.Client {

	[DataContract]
	public class VirtualRealityOptions {

		[DataMember(Name = "mirror_crop")]
		public object mirror_crop { get; set; } = false;

		[DataMember(Name = "enable")]
		public object enable { get; set; } = false;

		[DataMember(Name = "custom_IPD_enable")]
		public object custom_IPD_enable { get; set; } = false;

		[DataMember(Name = "box_mouse_cursor")]
		public object box_mouse_cursor { get; set; } = false;

		[DataMember(Name = "msaaMaskSize")]
		public object msaaMaskSize { get; set; } = 0.45;

		[DataMember(Name = "pixel_density")]
		public object pixel_density { get; set; } = 1.5;

		[DataMember(Name = "use_mouse")]
		public object use_mouse { get; set; } = true;

		[DataMember(Name = "mirror_use_DCS_resolution")]
		public object mirror_use_DCS_resolution { get; set; } = false;

		[DataMember(Name = "prefer_built_in_audio")]
		public object prefer_built_in_audio { get; set; } = true;

		[DataMember(Name = "interaction_with_grip_only")]
		public object interaction_with_grip_only { get; set; } = false;

		[DataMember(Name = "bloom")]
		public object bloom { get; set; } = true;

		[DataMember(Name = "mirror_source")]
		public object mirror_source { get; set; } = 0;

		[DataMember(Name = "custom_IPD")]
		public object custom_IPD { get; set; } = 63.5;

		[DataMember(Name = "hand_controllers")]
		public object hand_controllers { get; set; } = false;

	}

}
