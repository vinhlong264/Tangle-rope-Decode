using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class UserPaymentDataSaver : MonoBehaviour
	{
		[SerializeField]
		private PersistentUserPayments payments;

		[SerializeField]
		private IAPStoreControllerChannel store;

		[SerializeField]
		private IAPDataService service;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void AddNewProductPayment(Product product)
		{
		}
	}
}
