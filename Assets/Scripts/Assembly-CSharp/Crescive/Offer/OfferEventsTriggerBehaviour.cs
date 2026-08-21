using UnityEngine;

namespace Crescive.Offer
{
	public class OfferEventsTriggerBehaviour : MonoBehaviour
	{
		[SerializeField]
		private OfferEvents offerEvents;

		[SerializeField]
		[Header("Settings")]
		private bool forceEvents;

		private OfferEventArgs eventArgs;

		public void SetArgs(OfferEventArgs args)
		{
		}

		public void TriggerOfferShownEvent()
		{
		}

		public void TriggerOfferPurchasedEvent()
		{
		}

		public void TriggerOfferCanceledEvent()
		{
		}

		public void TriggerOfferClosedEvent()
		{
		}
	}
}
