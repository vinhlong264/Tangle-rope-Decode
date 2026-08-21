using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	public class BasicShopBundlesViewController : BaseShopBundlesViewController
	{
		[SerializeField]
		private BaseShopBundlePackViewControllerSettings bundlePackViewControllerSettings;

		[SerializeField]
		private List<string> bundleIds;

		protected override bool CanSetup()
		{
			return false;
		}

		protected override List<Bundle> GetItems()
		{
			return null;
		}

		protected override ShopBundleViewController GetItemPrefab(string itemId)
		{
			return null;
		}

		public void SetBundleIds(List<string> ids)
		{
		}
	}
}
