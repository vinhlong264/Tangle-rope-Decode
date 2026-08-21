using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LadderOffer
{
	[DefaultExecutionOrder(1)]
	public class LadderOfferItemViewListener : MonoBehaviour
	{
		[SerializeField]
		private LadderOfferItemView ladderOfferItemView;

		[Header("Setup Events")]
		public UnityEvent<string> OnSetupBundleId;

		[Header("Claim Events")]
		public UnityEvent<LadderOfferItemView> OnStartClaim;

		public UnityEvent<LadderOfferItemView> OnPerformClaim;

		public UnityEvent OnCanNotClaim;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToEvents()
		{
		}

		private void UnsubscribeFromEvents()
		{
		}

		private void OnSetupFinishedCallback()
		{
		}
	}
}
