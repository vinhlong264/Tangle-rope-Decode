using UnityEngine;

namespace Crescive.Shop
{
	public abstract class BaseShopBundlePackViewControllerSettings : ScriptableObject
	{
		public abstract ShopBundleViewController GetPrefab(string id);
	}
}
