using Crescive.Channels;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Offer
{
	[CreateAssetMenu(fileName = "Offer Controller Channel", menuName = "Crescive/Offer/Offer Controller Channel")]
	public class OfferControllerChannel : ObjectChannel<OfferController>
	{
		public UnityEvent OnBeforeRequestOffer => null;

		public UnityEvent OnRequestedOffer => null;

		public UnityEvent<OfferDataWrapper> OnOfferRequestResult => null;

		public bool IsRequesting => false;
	}
}
