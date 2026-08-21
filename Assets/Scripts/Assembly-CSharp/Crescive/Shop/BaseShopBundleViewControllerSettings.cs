using UnityEngine;

namespace Crescive.Shop
{
	public abstract class BaseShopBundleViewControllerSettings : ScriptableObject
	{
		public abstract ShopBundleProductViewController GetPrefab(string id, ShopProductType productType);
	}
}
