using Crescive.IAP;
using Crescive.Scheduler;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.LadderOffer
{
	[DefaultExecutionOrder(-10000000)]
	public class LadderOfferSystemController : MonoBehaviour
	{
		[SerializeField]
		private LadderOfferSystem ladderOfferSystem;

		[SerializeField]
		private IAPStoreControllerChannel storeControllerChannel;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncData()
		{
		}

		private void OnLadderOfferScheduleActivatedNowCallback(ScheduleActivatedNowArgs args)
		{
		}

		private void OnItemClaimed(string itemId, string info = null)
		{
		}

		private void OnPurchaseCompletedCallback(Product product)
		{
		}
	}
}
