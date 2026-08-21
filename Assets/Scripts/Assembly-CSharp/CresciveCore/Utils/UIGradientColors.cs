using System;
using UnityEngine;

namespace CresciveCore.Utils
{
	[Serializable]
	public struct UIGradientColors
	{
		public Color Color1;

		public Color Color2;

		public Color Color3;

		public Color Color4;

		public UIGradientColors(Color color1, Color color2, Color color3, Color color4)
		{
			Color1 = default(Color);
			Color2 = default(Color);
			Color3 = default(Color);
			Color4 = default(Color);
		}

		public UIGradientColors(Color color1, Color color2)
		{
			Color1 = default(Color);
			Color2 = default(Color);
			Color3 = default(Color);
			Color4 = default(Color);
		}
	}
}
