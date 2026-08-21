using ElephantSDK;
using PersistentSO;
using UnityEngine;

namespace Crescive.Offer
{
	[CreateAssetMenu(fileName = "Persistent Offers Data", menuName = "Crescive/Offer/Persistent Offers Data")]
	public class PersistentOffersData : PersistentListVariable<OfferDataWrapper>
	{
		public override OfferDataWrapper GetItemCopy(OfferDataWrapper item)
		{
			return null;
		}

		public void AddSafe(OfferData offerData)
		{
		}

		public OfferData GetOfferDataByName(string offerName)
		{
			return null;
		}
	}
}
