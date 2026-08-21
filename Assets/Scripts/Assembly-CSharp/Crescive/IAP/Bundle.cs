using System;
using System.Collections.Generic;

namespace Crescive.IAP
{
	[Serializable]
	public class Bundle : ICloneable, IProductInfo
	{
		public ProductInfo BundleInfo;

		public List<string> ProductIds;

		private List<string> Ids => null;

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

		public Bundle()
		{
		}

		public Bundle(Bundle other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
