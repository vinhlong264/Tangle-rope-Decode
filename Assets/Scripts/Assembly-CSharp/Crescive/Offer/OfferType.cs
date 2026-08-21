using System.ComponentModel;

namespace Crescive.Offer
{
	public enum OfferType
	{
		[Description("with_rw")]
		RW = 0,
		[Description("with_iap")]
		IAP = 1,
		[Description("with_currency")]
		Currency = 2
	}
}
