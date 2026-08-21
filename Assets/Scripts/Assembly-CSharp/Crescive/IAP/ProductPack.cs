using System;
using System.Collections.Generic;
using Crescive.DataService;

namespace Crescive.IAP
{
	[Serializable]
	public class ProductPack : ICloneable, IPackInfo, IMergeable<ProductPack>
	{
		public bool Enabled;

		public string Id;

		public string Name;

		public string Description;

		public List<ProductInfo> Products;

		public List<string> DisablerIds;

		public string id => null;

		public string description => null;

		public ProductPack()
		{
		}

		public ProductPack(ProductPack other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public void Merge(ProductPack other)
		{
		}

		public bool CanMergeWith(ProductPack other)
		{
			return false;
		}
	}
}
