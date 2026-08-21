using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Theming
{
	public class CountdownUIThemeBehaviour : BaseUIThemeBehaviour
	{
		[SerializeField]
		private Image textBackground;

		private UIThemeCountdownData CountdownData => null;

		protected override void ApplyThemeInternal()
		{
		}
	}
}
