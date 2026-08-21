using Crescive.Layout;
using UnityEngine;

namespace Systems.MiniShopSpecialOffers
{
	[DefaultExecutionOrder(1)]
	public class MiniShopOfferEgoEnabler : MonoBehaviour
	{
		[SerializeField]
		private SimpleScrollSnapDynamicObjectsController scrollSnapDynamicObjectsController;

		[SerializeField]
		private MiniShopSpecialOffersOfferUI offerUI;

		[SerializeField]
		private RectTransform enabledParent;

		[SerializeField]
		private RectTransform disabledParent;

		private bool isInScroll;

		private void OnEnable()
		{
		}

		private void CheckEgo()
		{
		}

		public void OnMiniShopEgoOfferPurchased()
		{
		}
	}
}
