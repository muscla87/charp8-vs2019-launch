using System;

namespace PatternMatching
{
	class SwitchExpressions
	{
		public enum Rainbow
		{
			Red,
			Orange,
			Yellow,
			Green,
			Blue,
			Indigo,
			Violet
		}

		public static RGBColor FromRainbowNew(Rainbow colorBand) =>
			colorBand switch
		{
			Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
			Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
			Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
			Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
			Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
			Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
			Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
			_ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
		};

		public static RGBColor FromRainbowOld(Rainbow colorBand)
		{
			switch (colorBand)
			{
				case Rainbow.Red:
					return new RGBColor(0xFF, 0x00, 0x00);
				case Rainbow.Orange:
					return new RGBColor(0xFF, 0x7F, 0x00);
				case Rainbow.Yellow:
					return new RGBColor(0xFF, 0xFF, 0x00);
				case Rainbow.Green:
					return new RGBColor(0x00, 0xFF, 0x00);
				case Rainbow.Blue:
					return new RGBColor(0x00, 0x00, 0xFF);
				case Rainbow.Indigo:
					return new RGBColor(0x4B, 0x00, 0x82);
				case Rainbow.Violet:
					return new RGBColor(0x94, 0x00, 0xD3);
				default:
					throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand));
			};
		}

		internal class RGBColor
		{
			private int v1;
			private int v2;
			private int v3;

			public RGBColor(int v1, int v2, int v3)
			{
				this.v1 = v1;
				this.v2 = v2;
				this.v3 = v3;
			}
		}
	}
}
