using System.Collections.Generic;
using Crescive.LadderOffer;
using UnityEngine;

namespace Crescive.Boosters
{
	public class LadderOffersElephantEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private LadderOfferSystem ladderOfferSystem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SendLadderOfferShownEvent(LadderOfferShownEventArgs args)
		{
		}

		private void SendLadderOfferItemClaimedEvent(LadderOfferItemClaimedEventArgs args)
		{
		}

		private Dictionary<string, object> GetBaseLadderOfferEventParameters(BaseLadderOfferEventArgs args)
		{
			return null;
		}

		private Dictionary<string, object> GetLadderOfferShownParameters(LadderOfferShownEventArgs args)
		{
			return null;
		}

		private Dictionary<string, object> GetLadderOfferItemClaimedParameters(LadderOfferItemClaimedEventArgs args)
		{
			return null;
		}
	}
}
