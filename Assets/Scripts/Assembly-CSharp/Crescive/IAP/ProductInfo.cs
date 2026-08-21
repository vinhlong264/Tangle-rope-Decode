using System;
using UnityEngine.Serialization;

namespace Crescive.IAP
{
	[Serializable]
	public class ProductInfo : ICloneable, IProductInfo
	{
		[FormerlySerializedAs("EnabledInShop")]
		public bool Enabled;

		public bool UseInShop;

		public string Name;

		public string Id;

		public string Description;

		public bool IsConsumable;

		public int Amount;

		public string AdjustEventToken;

		public string ElephantEventParam;

		public float Price;

		public bool enabled => false;

		public bool useInShop => false;

		public string name => null;

		public string id => null;

		public string description => null;

		public bool isConsumable => false;

		public int amount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string adjustEventToken => null;

		public string elephantEventParam => null;

		public float price => 0f;

		public ProductInfo()
		{
		}

		public ProductInfo(ProductInfo other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
