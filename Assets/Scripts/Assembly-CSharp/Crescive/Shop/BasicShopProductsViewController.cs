using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	public class BasicShopProductsViewController : BaseShopProductsViewController
	{
		[SerializeField]
		private ShopProductPackViewControllerSettings productPackViewControllerSettings;

		[SerializeField]
		private List<string> productIds;

		protected override bool CanSetup()
		{
			return false;
		}

		protected override List<ProductInfo> GetItems()
		{
			return null;
		}

		protected override ShopProductViewController GetItemPrefab(string itemId)
		{
			return null;
		}

		public void SetProductIds(List<string> ids)
		{
		}
	}
}
