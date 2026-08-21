using System;

namespace Crescive.Theming
{
	[Serializable]
	public class UIThemeVariablePair<T>
	{
		public UITheme Theme;

		public T Value;
	}
}
