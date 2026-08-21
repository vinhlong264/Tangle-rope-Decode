using System.Collections.Generic;
using Crescive.DataService;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "Mini Shop Data Service", menuName = "Crescive/Shop/Services/Mini Shop Data Service")]
	public class MiniShopDataService : DataReadService<MiniShopData>
	{
		[SerializeField]
		private IAPDataService iapDataService;

		protected override MiniShopData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(MiniShopData plainData)
		{
			return false;
		}

		public List<string> GetValidBundleIds()
		{
			return null;
		}

		public List<string> GetValidProductIds()
		{
			return null;
		}
	}
}
