using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Plinko
{
	public class PlinkoMarketItem : MonoBehaviour
	{
		[SerializeField]
		private ItemDisplayer itemDisplayer;

		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private GameObject currencyIcon;

		[SerializeField]
		private GameObject tickIcon;

		[SerializeField]
		private Button buyButton;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private TextMeshProUGUI priceText;

		[SerializeField]
		private GameObject notEnoughTicketsTooltip;

		private int index;

		private Action<int> onMarketItemClicked;

		private Sequence sequence;

		private float defaultY;

		public ProbabilityRewardRemote data { get; private set; }

		public void SetData(ProbabilityRewardRemote data, int index, Action<int> onMarketItemClicked)
		{
		}

		public void UpdateData(ProbabilityRewardRemote data, float delay = 0.1f)
		{
		}

		private void OnBuyButtonClicked()
		{
		}

		private void OnMarketItemClicked()
		{
		}
	}
}
