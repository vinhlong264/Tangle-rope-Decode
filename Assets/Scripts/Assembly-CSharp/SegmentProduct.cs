using System;
using System.Collections.Generic;
using SegmentedOffers;

[Serializable]
public class SegmentProduct
{
	public int tier;

	public string iapId;

	public int goldAmount;

	public List<SegmentedProduct> products;
}
