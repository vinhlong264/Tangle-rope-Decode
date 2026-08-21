using System;
using System.Collections.Generic;

namespace Game.Scripts.Shop.Logic
{
	[Serializable]
	public class MainShopFilterData : ICloneable
	{
		public List<string> Bundles;

		public List<string> Products;

		public MainShopFilterData()
		{
		}

		public MainShopFilterData(MainShopFilterData data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
