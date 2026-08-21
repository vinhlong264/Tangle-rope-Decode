using System;
using UnityEngine;

namespace Crescive.Shop
{
	[Serializable]
	public class ShopProductAssetDataByProductId : BaseShopProductAssetDataByProductId
	{
		[SerializeField]
		private ShopProductAssetData data;

		public override ShopProductAssetData Data => null;
	}
}
