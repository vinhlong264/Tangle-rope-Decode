using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.Analytics
{
	public class FirebasePurchaseEventsIntegration : MonoBehaviour
	{
		[SerializeField]
		private List<string> productIds;

		[SerializeField]
		private IAPStoreControllerChannel storeChannel;

		[SerializeField]
		private IAPDataService service;

		private List<string> Ids => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPurchaseCompletedCallback(Product product)
		{
		}

		private void SendPaymentEvent(string id)
		{
		}
	}
}
