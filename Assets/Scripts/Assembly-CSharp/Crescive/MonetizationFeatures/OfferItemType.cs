using System.ComponentModel;

namespace Crescive.MonetizationFeatures
{
	public enum OfferItemType
	{
		[Description("Free")]
		Free = 0,
		[Description("RW")]
		RW = 1,
		[Description("IAP")]
		IAP = 2
	}
}
