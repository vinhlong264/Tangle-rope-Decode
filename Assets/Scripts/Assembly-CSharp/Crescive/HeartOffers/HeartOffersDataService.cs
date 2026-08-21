using Crescive.DataService;
using UnityEngine;

namespace Crescive.HeartOffers
{
	[CreateAssetMenu(fileName = "Heart Offers Data Service", menuName = "Crescive/Monetization Features/Heart Offers/Service/Heart Offers Data Service")]
	public class HeartOffersDataService : DataReadService<HeartOffersSettings>
	{
		protected override HeartOffersSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(HeartOffersSettings plainData)
		{
			return false;
		}
	}
}
