using UnityEngine;

namespace Crescive.LadderOffer
{
	public abstract class BaseLadderOfferItemViewSettings : ScriptableObject
	{
		public abstract LadderOfferItemViewSettingsResult GetSettingsResult(LadderOfferItemViewSetupArgs args);
	}
}
