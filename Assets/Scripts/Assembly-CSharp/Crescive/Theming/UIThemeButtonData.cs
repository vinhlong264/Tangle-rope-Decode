using System;
using UnityEngine;

namespace Crescive.Theming
{
	[Serializable]
	public class UIThemeButtonData
	{
		public Sprite primaryButtonBackground;

		public Sprite secondaryButtonBackground;

		public Sprite tertiaryButtonBackground;

		public Sprite quaternaryButtonBackground;

		public Sprite GetButtonBackground(UIThemeElementLevel buttonBackgroundLevel)
		{
			return null;
		}
	}
}
