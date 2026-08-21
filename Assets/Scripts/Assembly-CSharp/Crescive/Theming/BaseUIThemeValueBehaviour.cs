using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Theming
{
	public class BaseUIThemeValueBehaviour<T> : BaseUIThemeBehaviour
	{
		[SerializeField]
		protected UIThemeValue<T> themeValue;

		public UnityEvent<T> OnThemeValueChanged;

		protected override void ApplyThemeInternal()
		{
		}

		protected virtual void ThemeValueChangedInternal(T value)
		{
		}
	}
}
