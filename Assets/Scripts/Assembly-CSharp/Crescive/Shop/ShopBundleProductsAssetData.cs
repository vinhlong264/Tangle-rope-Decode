using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "Shop Bundle Products Asset Data", menuName = "Crescive/Shop/UI/Product/Shop Bundle Products Asset Data")]
	public class ShopBundleProductsAssetData : ScriptableObject
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private ShopProductsAssetData shopProductsAssetData;

		[SerializeField]
		private List<ShopProductAssetDataByProductId> shopProductsAssetDataOverrides;

		[SerializeField]
		private List<ShopProductAssetDataByProductPackId> bundleProductAssetData;

		public ShopProductAssetData GetBundleProductAssetData(ProductInfo productInfo)
		{
			return null;
		}

		private ShopProductAssetData GetProductAssetDataIncludingOverrides(string productId)
		{
			return null;
		}
	}
}
