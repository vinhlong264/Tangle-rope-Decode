using System;
using System.Collections.Generic;

namespace Crescive.IAP
{
	[Serializable]
	public class UserPaymentData
	{
		public List<ProductPaymentData> ProductPayments;

		public UserPaymentData(UserPaymentData other)
		{
		}

		public UserPaymentData(List<ProductPaymentData> productPayments)
		{
		}

		public int GetPaymentCount()
		{
			return 0;
		}

		public float GetTotalRevenue()
		{
			return 0f;
		}

		public List<string> GetPurchasedProductIds()
		{
			return null;
		}

		public List<string> GetNonConsumablePurchasedProductIds()
		{
			return null;
		}

		public int GetPaymentCountForProduct(string productId)
		{
			return 0;
		}
	}
}
