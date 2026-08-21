using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace Crescive.LadderOffer
{
	[CreateAssetMenu(fileName = "Ladder Offer All Claimed Condition", menuName = "Crescive/Monetization Features/Ladder Offer/Ladder Offer All Claimed Condition")]
	public class LadderOfferAllClaimedCondition : AtomCondition
	{
		[SerializeField]
		private LadderOfferSystem ladderOfferSystem;

		[SerializeField]
		private string ladderOfferId;

		[SerializeField]
		private bool reverse;

		private List<string> LadderOfferIds => null;

		public override bool Call()
		{
			return false;
		}
	}
}
