using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Theming
{
	public abstract class UIThemeValue<T> : ScriptableObject
	{
		[SerializeField]
		private T defaultValue;

		[SerializeField]
		private List<UIThemeVariablePair<T>> themeValues;

		public T GetValueForTheme(UITheme theme)
		{
			return default(T);
		}
	}
}
