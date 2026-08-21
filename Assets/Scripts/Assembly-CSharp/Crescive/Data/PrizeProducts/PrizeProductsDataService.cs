using Crescive.DataService;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Data.PrizeProducts
{
	[CreateAssetMenu(menuName = "Crescive/PrizeProducts/PrizeProductsDataService")]
	public class PrizeProductsDataService : DataReadService<AllPrizeProductSettings>
	{
		[SerializeField]
		private IAPStoreControllerChannel iapStoreControllerChannel;

		protected override AllPrizeProductSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(AllPrizeProductSettings plainData)
		{
			return false;
		}

		public bool HasSettings(string id)
		{
			return false;
		}

		public PrizeProductSettings GetSettings(string id)
		{
			return null;
		}

		public void Claim(string id)
		{
		}
	}
}
