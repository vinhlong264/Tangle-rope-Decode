using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PersistentSO;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	[CreateAssetMenu(fileName = "Persistent User Payments", menuName = "Crescive/IAP/User Payments/Persistent User Payments")]
	public class PersistentUserPayments : PersistentVariable<UserPaymentData>
	{
		public event Action<ProductPaymentData> OnNewProductPaymentAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override UserPaymentData GetCopy(UserPaymentData value)
		{
			return null;
		}

		public void AddNewProductPayment(ProductPaymentData productPaymentData)
		{
		}

		public void AddNewProductPayment(Product product, float price)
		{
		}

		public int GetTotalPaymentCount()
		{
			return 0;
		}

		public int GetSessionPaymentCount()
		{
			return 0;
		}

		public float GetTotalPaymentRevenue()
		{
			return 0f;
		}

		public float GetSessionPaymentRevenue()
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

		public bool HasPurchasedNonConsumableProduct(string productId)
		{
			return false;
		}
	}
}
