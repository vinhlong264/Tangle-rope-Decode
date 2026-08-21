using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Theming
{
	public class PopupUIThemeBehaviour : BaseUIThemeBehaviour
	{
		[SerializeField]
		private Image background;

		[SerializeField]
		private UIGradient backgroundGradient;

		[SerializeField]
		private Image titleBackground;

		private UIThemePopupData PopupData => null;

		protected override void ApplyThemeInternal()
		{
		}
	}
}
