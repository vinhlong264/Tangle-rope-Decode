using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class IAPAdjustEventsSender : MonoBehaviour
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private IAPStoreControllerChannel controllerChannel;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SendProductPurchasedAdjustEvent(Product purchasedProduct)
		{
		}
	}
}
