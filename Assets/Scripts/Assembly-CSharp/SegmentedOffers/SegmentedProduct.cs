using System;

namespace SegmentedOffers
{
	[Serializable]
	public class SegmentedProduct
	{
		public ProductType productType;

		public int productAmount;

		public SegmentedProduct(ProductType productType, int productAmount)
		{
		}
	}
}
