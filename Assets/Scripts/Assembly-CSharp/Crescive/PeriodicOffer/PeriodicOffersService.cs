using Crescive.DataService;
using UnityEngine;

namespace Crescive.PeriodicOffer
{
	[CreateAssetMenu(menuName = "Crescive/Periodic Offer/Service/Periodic Offers Service")]
	public class PeriodicOffersService : DataReadService<PeriodicOffersSettings>
	{
		protected override PeriodicOffersSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(PeriodicOffersSettings plainData)
		{
			return false;
		}

		public bool HasOfferSettings(string id)
		{
			return false;
		}

		public PeriodicOfferSettings GetOfferSettings(string id)
		{
			return null;
		}
	}
}
