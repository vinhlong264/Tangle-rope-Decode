using UnityEngine;

namespace Crescive.LadderOffer
{
	[CreateAssetMenu(fileName = "Ladder Offer Item View Settings", menuName = "Crescive/Monetization Features/Ladder Offer/UI/Ladder Offer Item View Settings")]
	public class LadderOfferItemViewSettings : BaseLadderOfferItemViewSettings
	{
		[SerializeField]
		private LadderOfferItemViewSettingsData viewSettingsData;

		public override LadderOfferItemViewSettingsResult GetSettingsResult(LadderOfferItemViewSetupArgs args)
		{
			return null;
		}
	}
}
