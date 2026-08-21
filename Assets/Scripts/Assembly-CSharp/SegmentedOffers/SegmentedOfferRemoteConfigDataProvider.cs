using Crescive.DataService;
using UnityEngine;

namespace SegmentedOffers
{
	[CreateAssetMenu(fileName = "SegmentedOfferRemoteConfigDataProvider", menuName = "Crescive/SegmentedOffer/DataService/Segmented OfferData Remote")]
	public class SegmentedOfferRemoteConfigDataProvider : RemoteConfigDataProvider<SegmentedOfferSettings>
	{
		public override void Get(DataProviderGetCallback<SegmentedOfferSettings> getCallback)
		{
		}
	}
}
