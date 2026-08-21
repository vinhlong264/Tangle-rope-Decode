using System;
using Crescive.UI;
using UnityEngine;

namespace Crescive.Shop
{
	[Serializable]
	public class ShopProductAssetData : ISpriteSource
	{
		[SerializeField]
		private Sprite icon;

		[SerializeField]
		private Sprite iconL;

		[SerializeField]
		private Sprite iconXL;

		public Sprite Sprite => null;

		public Sprite SpriteL => null;

		public Sprite SpriteXL => null;

		public ShopProductAssetData(Sprite icon)
		{
		}
	}
}
