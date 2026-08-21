using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "Shop Bundle Pack View Settings", menuName = "Crescive/Shop/UI/Bundle/Shop Bundle Pack View Settings")]
	public class ShopBundlePackViewControllerSettings : BaseShopBundlePackViewControllerSettings
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		[Space]
		private ShopBundleViewController defaultViewPrefab;

		[SerializeField]
		private List<ShopBundlePackViewDataWithBundleId> viewPrefabsWithBundleId;

		[SerializeField]
		private List<ShopBundlePackViewDataWithBundlePackId> viewPrefabsWithBundlePackId;

		public override ShopBundleViewController GetPrefab(string id)
		{
			return null;
		}
	}
}
