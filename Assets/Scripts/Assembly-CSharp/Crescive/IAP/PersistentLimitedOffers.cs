using PersistentSO;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/PersistentLimitedOffers")]
	public class PersistentLimitedOffers : PersistentListVariable<LimitedOfferData>
	{
		public override LimitedOfferData GetItemCopy(LimitedOfferData item)
		{
			return null;
		}

		public bool HasOffer(string productId)
		{
			return false;
		}

		public LimitedOfferData GetOffer(string productId)
		{
			return null;
		}

		public void SetOffer(LimitedOfferData offer)
		{
		}

		public bool IsOffering(string productId)
		{
			return false;
		}

		public float GetClosestOfferExpireRemainingSeconds()
		{
			return 0f;
		}
	}
}
