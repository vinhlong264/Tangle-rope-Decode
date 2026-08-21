using System.Collections.Generic;
using Crescive.Layout;
using UnityEngine;

namespace Systems.MiniShopSpecialOffers
{
	public class MiniShopSpecialOffersUI : MonoBehaviour
	{
		[SerializeField]
		private SimpleScrollSnapDynamicObjectsController scrollSnapDynamicObjectsController;

		[SerializeField]
		private GameObject refreshInXContent;

		[SerializeField]
		private RectTransform contentParent;

		[SerializeField]
		private MiniShopSpecialOffersOfferUI offerUIPrefab;

		private List<MiniShopSpecialOffersOfferUI> offerUIs;

		[SerializeField]
		private RewardDisplayer rewardDisplayer;

		private Transform refreshTimeContentParent;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnMiniShopOffersPurchased(MiniShopSpecialOffersEvents.OnMiniShopOffersPurchased p)
		{
		}

		private void OnRewardsClaimed()
		{
		}

		private void OnMiniShopOffersEnabled()
		{
		}

		private void OnMiniShopOffersDisabled()
		{
		}

		private void OnMiniShopOffersRefreshed()
		{
		}

		private void UpdateUI()
		{
		}
	}
}
