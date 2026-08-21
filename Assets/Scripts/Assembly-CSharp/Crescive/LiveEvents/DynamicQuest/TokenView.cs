using Crescive.HelperTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class TokenView : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private FloatSettableVariableReference amountVar;

		[SerializeField]
		private TMP_Text amountTmp;

		[SerializeField]
		private Image icon;

		public CanvasGroup CanvasGroup => null;

		public void SetAmount(float amount)
		{
		}

		public void MultiplyAmount(float multiplier)
		{
		}

		public void SetTextColor(Color color)
		{
		}

		public void SetIcon(Sprite sprite)
		{
		}
	}
}
