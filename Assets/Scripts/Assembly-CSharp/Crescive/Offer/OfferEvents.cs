using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Offer
{
	[CreateAssetMenu(fileName = "Offer Events", menuName = "Crescive/Analytics/Events/Offer Events")]
	public class OfferEvents : ScriptableObject
	{
		[Header("Settings")]
		[SerializeField]
		private BoolVariableReference canSendOfferEvents;

		[Header("Events")]
		public UnityEvent<OfferEventArgs> OnOfferShown;

		public UnityEvent<OfferEventArgs> OnOfferPurchased;

		public UnityEvent<OfferEventArgs> OnOfferCanceled;

		public UnityEvent<OfferEventArgs> OnOfferClosed;

		private bool CanSendOfferEvents(bool force)
		{
			return false;
		}

		public void TriggerOfferShown(OfferEventArgs args, bool force = false)
		{
		}

		public void TriggerOfferPurchased(OfferEventArgs args, bool force = false)
		{
		}

		public void TriggerOfferCanceled(OfferEventArgs args, bool force = false)
		{
		}

		public void TriggerOfferClosed(OfferEventArgs args, bool force = false)
		{
		}
	}
}
