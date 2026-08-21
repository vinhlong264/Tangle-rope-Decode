using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Offer
{
	public class OfferElephantEventsSender : MonoBehaviour
	{
		[SerializeField]
		private OfferEvents offerEvents;

		[SerializeField]
		private PersistentOffersData persistentOffersData;

		[SerializeField]
		private StringVariable triggerPoint;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SendOfferShownEvent(OfferEventArgs args)
		{
		}

		private void SendOfferPurchasedEvent(OfferEventArgs args)
		{
		}

		private void SendOfferCanceledEvent(OfferEventArgs args)
		{
		}

		private void SendOfferClosedEvent(OfferEventArgs args)
		{
		}
	}
}
