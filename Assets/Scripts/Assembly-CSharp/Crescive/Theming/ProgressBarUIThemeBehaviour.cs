using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Theming
{
	public class ProgressBarUIThemeBehaviour : BaseUIThemeBehaviour
	{
		[SerializeField]
		private Image barBackground;

		[SerializeField]
		private Image barFillBackground;

		[SerializeField]
		private Image barFill;

		private UIThemeProgressBarData ProgressBarData => null;

		protected override void ApplyThemeInternal()
		{
		}
	}
}
