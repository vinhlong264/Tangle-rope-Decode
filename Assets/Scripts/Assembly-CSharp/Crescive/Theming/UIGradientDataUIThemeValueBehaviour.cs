using System.Collections.Generic;
using Coffee.UIEffects;
using UnityEngine;

namespace Crescive.Theming
{
	public class UIGradientDataUIThemeValueBehaviour : BaseUIThemeValueBehaviour<UIGradientData>
	{
		[SerializeField]
		private List<UIGradient> uiGradients;

		protected override void ThemeValueChangedInternal(UIGradientData value)
		{
		}
	}
}
