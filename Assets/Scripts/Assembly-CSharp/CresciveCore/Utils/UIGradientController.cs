using Coffee.UIEffects;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace CresciveCore.Utils
{
	[DefaultExecutionOrder(-100)]
	public class UIGradientController : MonoBehaviour
	{
		[SerializeField]
		private UIGradientControllerEvents uiGradientControllerEvents;

		[SerializeField]
		private UIGradient uiGradient;

		[SerializeField]
		private Image gradientBottomImage;

		[SerializeField]
		private float setDuration;

		[SerializeField]
		private Ease setEase;

		[SerializeField]
		private UIGradientColors originalColors;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetColor1(Color color)
		{
		}

		public void SetColor2(Color color)
		{
		}

		public void SetColor3(Color color)
		{
		}

		public void SetColor4(Color color)
		{
		}

		public void SetTwoColors(UIGradientColors colors, bool animate)
		{
		}

		public void SetAllColors(UIGradientColors colors, bool animate)
		{
		}

		public void RestoreOriginalColors(bool animate)
		{
		}
	}
}
