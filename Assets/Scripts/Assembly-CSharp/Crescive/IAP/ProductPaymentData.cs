using System;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	[Serializable]
	public class ProductPaymentData : ICloneable
	{
		public string ProductId;

		public float Price;

		public UnityEngine.Purchasing.ProductType ProductType;

		public string Date;

		public string TxId;

		public ProductPaymentData(string productId, float price, UnityEngine.Purchasing.ProductType productType, string date)
		{
		}

		public ProductPaymentData(ProductPaymentData other)
		{
		}

		public ProductPaymentData(Product product, float price)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
