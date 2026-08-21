using System;
using System.Collections.Generic;

namespace Crescive.Shop
{
	[Serializable]
	public class MiniShopData : ICloneable
	{
		public List<string> Bundles;

		public List<string> Products;

		public MiniShopData(List<string> bundles, List<string> products)
		{
		}

		public MiniShopData(MiniShopData data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
