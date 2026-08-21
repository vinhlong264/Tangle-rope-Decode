using Crescive.Navigation;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Offer
{
	[CreateAssetMenu(fileName = "Offer Conditional Show Action", menuName = "Crescive/Offer/Actions/Offer Conditional Show Action")]
	public class OfferRequestActions : ScriptableObject
	{
		[SerializeField]
		private UnityEvent<string> OnPushOfferPopupId;

		[SerializeField]
		private NavigatableStackPopUpCanShowCondition canShowCondition;

		[SerializeField]
		private NavigationChannel offerPopupNavigationChannel;

		[SerializeField]
		private OfferTriggerPointSequenceStepsData offerTriggerPointSequenceStepsData;

		private void FinishSequenceStepIfExists(string triggerPoint)
		{
		}

		private void SubscribeStepToOfferPopupPopIfExists(string triggerPoint, string offerPopupId)
		{
		}

		public void OnOfferRequestResult(string triggerPoint, OfferDataWrapper offerDataWrapper)
		{
		}

		public void TryShowOffer(string triggerPoint, string offerPopupId)
		{
		}

		public void ShowOffer(string offerId)
		{
		}
	}
}
