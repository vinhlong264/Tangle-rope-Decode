using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Plinko
{
	public class PlinkoMarketController : MonoBehaviour
	{
		[SerializeField]
		private Button refreshButton;

		[SerializeField]
		private GameObject notEnoughTicketsTooltip;

		[SerializeField]
		private TextMeshProUGUI[] refreshCurrencyAmounts;

		[SerializeField]
		private PlinkoMarketItem[] plinkoMarketItems;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTutorialRefreshClicked(PlinkoEvents.OnTutorialRefreshClicked p)
		{
		}

		private void WriteRefreshAmount()
		{
		}

		private int GetRefreshPrice()
		{
			return 0;
		}

		private void OnRefreshButtonClicked()
		{
		}

		private void RefreshItems()
		{
		}

		public void OnShopItemPurchased(int shopItemIndex)
		{
		}

		private void GiveRewards(ProbabilityRewardRemote probabilityRewardRemote, int shopItemIndex)
		{
		}

		private ProbabilityRewardRemote GetShopItem(PlinkoData data)
		{
			return null;
		}
	}
}
