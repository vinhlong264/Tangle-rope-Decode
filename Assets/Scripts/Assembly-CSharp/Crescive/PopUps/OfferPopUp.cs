using Crescive.Offer;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PopUps
{
	public class OfferPopUp : PopUp
	{
		[SerializeField]
		private bool autoCloseOnApprove;

		[SerializeField]
		private bool autoCloseOnDecline;

		private OfferOpeningType lastOpeningType;

		public UnityEvent OnApprove;

		public UnityEvent OnAfterApprove;

		public UnityEvent OnDecline;

		public UnityEvent OnAfterDecline;

		public OfferOpeningType LastOpeningType => default(OfferOpeningType);

		private void OnDisable()
		{
		}

		public void CustomShowForced()
		{
		}

		public void OnClickApprove()
		{
		}

		public void OnClickDecline()
		{
		}

		public void OnClickClose()
		{
		}

		protected override bool CanShowInternal()
		{
			return false;
		}
	}
}
