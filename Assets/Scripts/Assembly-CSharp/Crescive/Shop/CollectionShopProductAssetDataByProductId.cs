using System;
using Crescive.Collection;
using UnityEngine;

namespace Crescive.Shop
{
	[Serializable]
	public class CollectionShopProductAssetDataByProductId : BaseShopProductAssetDataByProductId
	{
		[SerializeField]
		private BaseCollectionItemGameData itemGameData;

		public override ShopProductAssetData Data => null;
	}
}
