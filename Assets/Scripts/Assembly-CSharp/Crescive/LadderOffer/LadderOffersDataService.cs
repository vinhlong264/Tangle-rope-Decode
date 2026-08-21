using System.Collections.Generic;
using Crescive.DataService;
using UnityEngine;

namespace Crescive.LadderOffer
{
	[CreateAssetMenu(fileName = "Ladder Offers Data Service", menuName = "Crescive/Monetization Features/Ladder Offer/Service/Ladder Offers Data Service")]
	public class LadderOffersDataService : DataReadService<LadderOffersData>
	{
		protected override LadderOffersData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LadderOffersData plainData)
		{
			return false;
		}

		public LadderOfferData GetLadderOfferData(string id)
		{
			return null;
		}

		public LadderOfferData GetLadderOfferDataByItemId(string itemId)
		{
			return null;
		}

		public List<string> GetLadderOfferIds(bool includeEmpty)
		{
			return null;
		}
	}
}
