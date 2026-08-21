using PersistentSO;
using UnityEngine;

namespace Crescive.PeriodicOffer
{
	[CreateAssetMenu(menuName = "Crescive/PeriodicOffer/PersistentPeriodicOffers")]
	public class PersistentPeriodicOffers : PersistentListVariable<PeriodicOfferData>
	{
		public override PeriodicOfferData GetItemCopy(PeriodicOfferData item)
		{
			return null;
		}

		public bool HasOffer(string id)
		{
			return false;
		}

		public PeriodicOfferData GetOrAddOffer(string id)
		{
			return null;
		}

		public void SetOffer(PeriodicOfferData offer)
		{
		}

		public void AddOfferDateFromNow(string id, float seconds)
		{
		}

		public bool IsOffering(string id)
		{
			return false;
		}

		public float GetClosestOfferExpireRemainingSeconds()
		{
			return 0f;
		}
	}
}
