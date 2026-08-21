using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Theming
{
	public class ButtonUIThemeBehaviour : BaseUIThemeBehaviour
	{
		[SerializeField]
		private Image buttonBackground;

		[SerializeField]
		private UIThemeElementLevel buttonBackgroundLevel;

		private UIThemeButtonData ButtonData => null;

		protected override void ApplyThemeInternal()
		{
		}
	}
}
