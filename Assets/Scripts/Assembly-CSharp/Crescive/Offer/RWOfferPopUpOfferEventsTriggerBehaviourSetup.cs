using Crescive.Ads;
using Crescive.Navigation;
using Crescive.PopUps;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Offer
{
	public class RWOfferPopUpOfferEventsTriggerBehaviourSetup : BaseOfferEventsTriggerBehaviourSetup
	{
		[SerializeField]
		private OfferEventsTriggerBehaviour offerEventsTriggerBehaviour;

		[SerializeField]
		private OfferPopUp offerPopUp;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private RewardedResourceSpenderDelegate rewardedResourceSpenderDelegate;

		[SerializeField]
		[Header("Data")]
		private StringReference itemNameVar;

		[SerializeField]
		private IntReference itemAmountVar;

		protected override void SetupInternal()
		{
		}
	}
}
