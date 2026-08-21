using System;
using UnityEngine;

namespace Crescive.Shop
{
	[Serializable]
	public class ShopProductAssetDataByProductPackId
	{
		[SerializeField]
		private string productPackId;

		[SerializeField]
		private ShopProductAssetData data;

		public string ProductPackId => null;

		public ShopProductAssetData Data => null;
	}
}
