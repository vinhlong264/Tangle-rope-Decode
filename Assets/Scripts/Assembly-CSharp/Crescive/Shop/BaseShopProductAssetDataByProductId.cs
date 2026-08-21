using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Shop
{
	[Serializable]
	public abstract class BaseShopProductAssetDataByProductId
	{
		[SerializeField]
		private string id;

		private List<string> ProductIds => null;

		public string Id => null;

		public abstract ShopProductAssetData Data { get; }
	}
}
