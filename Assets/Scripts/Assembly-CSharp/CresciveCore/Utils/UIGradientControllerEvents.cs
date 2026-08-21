using UnityEngine;
using UnityEngine.Events;

namespace CresciveCore.Utils
{
	[CreateAssetMenu(fileName = "UIGradientControllerChannel", menuName = "Crescive/Utils/UIGradient/UIGradientControllerChannel")]
	public class UIGradientControllerEvents : ScriptableObject
	{
		public UnityEvent<UIGradientColors, bool> OnSetTwoColors;

		public UnityEvent<UIGradientColors, bool> OnSetAllColors;

		public UnityEvent<bool> OnRestoreOriginalColors;

		public void TriggerSetTwoColors(UIGradientColors colors, bool animate)
		{
		}

		public void TriggerSetAllColors(UIGradientColors colors, bool animate)
		{
		}

		public void TriggerRestoreOriginalColors(bool animate)
		{
		}
	}
}
