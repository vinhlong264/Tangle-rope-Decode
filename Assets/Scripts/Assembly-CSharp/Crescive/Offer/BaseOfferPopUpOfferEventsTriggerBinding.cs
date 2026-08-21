using Crescive.PopUps;
using UnityEngine;

namespace Crescive.Offer
{
	public abstract class BaseOfferPopUpOfferEventsTriggerBinding : MonoBehaviour
	{
		[SerializeField]
		protected OfferEventsTriggerBehaviour offerEventsTriggerBehaviour;

		[SerializeField]
		protected BaseOfferEventsTriggerBehaviourSetup offerEventsTriggerBehaviourSetup;

		[SerializeField]
		protected OfferPopUp offerPopUp;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected void TriggerSetup()
		{
		}

		protected void TriggerPurchased()
		{
		}

		protected void TriggerCanceled()
		{
		}

		private void TriggerShown()
		{
		}

		private void TriggerClosed()
		{
		}

		private void OnSetupDoneCallback()
		{
		}

		private void OnDeclineCallback()
		{
		}

		protected abstract void OnApproveCallback();
	}
}
