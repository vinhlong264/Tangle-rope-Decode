using System;
using UnityEngine;

namespace Crescive.Theming
{
	[Serializable]
	public class UIThemeColorData
	{
		public Color primaryColor;

		public Color secondaryColor;

		public Color tertiaryColor;

		public Color quaternaryColor;

		public Color GetColor(UIThemeElementLevel colorLevel)
		{
			return default(Color);
		}
	}
}
