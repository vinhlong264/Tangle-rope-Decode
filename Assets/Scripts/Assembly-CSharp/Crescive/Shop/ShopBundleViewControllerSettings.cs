using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "Shop Bundle View Settings", menuName = "Crescive/Shop/UI/Bundle/Shop Bundle View Settings")]
	public class ShopBundleViewControllerSettings : BaseShopBundleViewControllerSettings
	{
		[SerializeField]
		private ShopBundleViewControllerSettings baseSettings;

		[SerializeField]
		[Space]
		private ShopBundleProductViewController defaultViewPrefab;

		[SerializeField]
		private List<ShopBundleViewDataWithProductId> viewPrefabsWithProductId;

		[SerializeField]
		private List<ShopBundleViewDataWithProductPackId> viewPrefabsWithId;

		public override ShopBundleProductViewController GetPrefab(string id, ShopProductType productType)
		{
			return null;
		}

		private ShopBundleProductViewController GetPrefabFromBaseOrDefault(string id, ShopProductType productType)
		{
			return null;
		}

		private ShopBundleProductViewController FindView(string id, ShopProductType productType)
		{
			return null;
		}
	}
}
