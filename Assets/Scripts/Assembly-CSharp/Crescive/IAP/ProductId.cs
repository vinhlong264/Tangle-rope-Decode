using System;

namespace Crescive.IAP
{
	[Serializable]
	public class ProductId : ICloneable
	{
		public string Id;

		public ProductId()
		{
		}

		public ProductId(string id)
		{
		}

		public ProductId(ProductId other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public static implicit operator string(ProductId productId)
		{
			return null;
		}

		public static implicit operator ProductId(string id)
		{
			return null;
		}
	}
}
