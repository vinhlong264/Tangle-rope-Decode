using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "ShopProductsAssetData", menuName = "Crescive/Shop/UI/Product/ShopProductsAssetData")]
	public class ShopProductsAssetData : ScriptableObject
	{
		[SerializeField]
		private List<ShopProductAssetDataByProductId> productAssetData;

		[SerializeField]
		private List<CollectionShopProductAssetDataByProductId> collectionProductAssetData;

		private IEnumerable<BaseShopProductAssetDataByProductId> ProductsAssetData => null;

		public ShopProductAssetData GetProductAssetData(string productId)
		{
			return null;
		}

		public void ReportSpriteTextureSizes()
		{
		}
	}
}
