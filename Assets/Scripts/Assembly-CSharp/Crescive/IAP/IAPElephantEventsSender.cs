using Crescive.HelperTypes;
using CresciveCore;
using ElephantSDK;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class IAPElephantEventsSender : MonoBehaviour
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private IAPStoreControllerChannel controllerChannel;

		[SerializeField]
		private StringVariableReference currentSceneOrLevelType;

		[SerializeField]
		private IntReference currentStageIndex;

		private int LevelNumber => 0;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private string GetProductEventParam(string id)
		{
			return null;
		}

		private string GetProductEventParam(Product product)
		{
			return null;
		}

		private string GetProductEventParam(ElephantPayment product)
		{
			return null;
		}

		private void SendItemTappedEvent(string id)
		{
		}

		public void SendPaymentFailedEvent(Product product, PurchaseFailureReason reason)
		{
		}

		private void SendPaymentSuccessEvent(Product product)
		{
		}

		private void SendRestorePurchaseTappedEvent()
		{
		}

		private void SendRestorePurchaseSuccessEvent()
		{
		}

		private void SendRestorePurchaseFailedEvent(string reason)
		{
		}

		public void SendPaymentSuccessWithoutVerifyEvent(Product product)
		{
		}

		public void SendPurchaseStateActiveEvent(Product product)
		{
		}
	}
}
