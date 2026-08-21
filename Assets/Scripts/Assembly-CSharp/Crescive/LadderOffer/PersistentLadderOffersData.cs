using PersistentSO;
using UnityEngine;

namespace Crescive.LadderOffer
{
	[CreateAssetMenu(fileName = "Persistent Ladder Offers Data", menuName = "Crescive/Monetization Features/Ladder Offer/Persistent/Persistent Ladder Offers Data")]
	public class PersistentLadderOffersData : PersistentVariable<LadderOffersSaveData>
	{
		public override LadderOffersSaveData GetCopy(LadderOffersSaveData value)
		{
			return null;
		}
	}
}
