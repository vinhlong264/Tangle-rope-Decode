using Crescive.IAP;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Systems.MiniShopSpecialOffers
{
	public class MiniShopSpecialOffersOfferUI : MonoBehaviour
	{
		[SerializeField]
		private Image[] rewardContentBGs;

		[SerializeField]
		private GameObject[] rewardContents;

		[SerializeField]
		private ItemDisplayer[] itemDisplayers;

		[SerializeField]
		private TextMeshProUGUI offerNameText;

		[SerializeField]
		private TextMeshProUGUI remainingCountText;

		[SerializeField]
		private TextMeshProUGUI priceText;

		[SerializeField]
		private GameObject[] offerAnims;

		[SerializeField]
		private Button buyButton;

		[SerializeField]
		private IAPPurchaser iapPurchaser;

		[SerializeField]
		private GameObject biggerContainer;

		[SerializeField]
		private RectTransform rewardRow;

		[SerializeField]
		private HorizontalLayoutGroup horizontalLayoutGroup;

		[SerializeField]
		private bool isLevelEnd;

		private string productID;

		private int productIndex;

		public void SetData(string offerName, RewardList rewardsList, string productID, int iconIndex, int remainingCount, int totalCount, int productIndex)
		{
		}

		private void SetRewards(RewardList rewardsList)
		{
		}

		public void Set2Rewards()
		{
		}

		public void Set3Rewards()
		{
		}

		public void Set4Rewards()
		{
		}

		public void Set5Rewards()
		{
		}

		private void OnBuyButtonClicked()
		{
		}

		public void OnPurchaseSuccess()
		{
		}
	}
}
