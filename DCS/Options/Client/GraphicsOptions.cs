using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPT.API.DCS.Options.Client {

	[DataContract]
	public class GraphicsOptions {

		[DataMember(Name = "messagesFontScale")]
		public object messagesFontScale { get; set; } = 1;

		[DataMember(Name = "rainDroplets")]
		public object rainDroplets { get; set; } = true;

		[DataMember(Name = "preloadRadius")]
		public object preloadRadius { get; set; } = 100000;

		[DataMember(Name = "box_mouse_cursor")]
		public object box_mouse_cursor { get; set; } = false;

		[DataMember(Name = "anisotropy")]
		public object anisotropy { get; set; } = 1;

		[DataMember(Name = "water")]
		public object water { get; set; } = 1;

		[DataMember(Name = "motionBlur")]
		public object motionBlur { get; set; } = 0;

		[DataMember(Name = "visibRange")]
		public object visibRange { get; set; } = "High";

		[DataMember(Name = "treesVisibility")]
		public object treesVisibility { get; set; } = 5000;

		[DataMember(Name = "aspect")]
		public object aspect { get; set; } = 2.3888888888889;

		[DataMember(Name = "lights")]
		public object lights { get; set; } = 2;

		[DataMember(Name = "shadows")]
		public object shadows { get; set; } = 2;

		[DataMember(Name = "MSAA")]
		public object MSAA { get; set; } = 1;

		[DataMember(Name = "SSAA")]
		public object SSAA { get; set; } = 1;

		[DataMember(Name = "height")]
		public object height { get; set; } = 1440;

		[DataMember(Name = "forestDistanceFactor")]
		public object forestDistanceFactor { get; set; } = 0.9;

		[DataMember(Name = "cockpitGI")]
		public object cockpitGI { get; set; } = 0;

		[DataMember(Name = "terrainTextures")]
		public object terrainTextures { get; set; } = "max";

		[DataMember(Name = "multiMonitorSetup")]
		public object multiMonitorSetup { get; set; } = "1camera";

		[DataMember(Name = "shadowTree")]
		public object shadowTree { get; set; } = false;

		[DataMember(Name = "chimneySmokeDensity")]
		public object chimneySmokeDensity { get; set; } = 0;

		[DataMember(Name = "fullScreen")]
		public object fullScreen { get; set; } = false;

		[DataMember(Name = "DOF")]
		public object DOF { get; set; } = 0;

		[DataMember(Name = "clouds")]
		public object clouds { get; set; } = 1;

		[DataMember(Name = "flatTerrainShadows")]
		public object flatTerrainShadows { get; set; } = 1;

		[DataMember(Name = "useDeferredShading")]
		public object useDeferredShading { get; set; } = 1;

		[DataMember(Name = "textures")]
		public object textures { get; set; } = 2;

		[DataMember(Name = "width")]
		public object width { get; set; } = 3440;

		[DataMember(Name = "SSAO")]
		public object SSAO { get; set; } = 0;

		[DataMember(Name = "SSLR")]
		public object SSLR { get; set; } = 0;

		[DataMember(Name = "effects")]
		public object effects { get; set; } = 3;

		[DataMember(Name = "sceneryDistanceFactor")]
		public object sceneryDistanceFactor { get; set; } = 1;

		[DataMember(Name = "outputGamma")]
		public object outputGamma { get; set; } = 2.6;

		[DataMember(Name = "sync")]
		public object sync { get; set; } = true;

		[DataMember(Name = "LensEffects")]
		public object LensEffects { get; set; } = 0;

		[DataMember(Name = "heatBlr")]
		public object heatBlr { get; set; } = 0;

		[DataMember(Name = "scaleGui")]
		public object scaleGui { get; set; } = 1;

		[DataMember(Name = "civTraffic")]
		public object civTraffic { get; set; } = "low";

		[DataMember(Name = "clutterMaxDistance")]
		public object clutterMaxDistance { get; set; } = 600;

	}

}
