using Crescive.LadderOffer;
using UnityEngine;

namespace DirectStore.Scripts.DirectStoreHelpers
{
	public class DirectStoreActivationCheckerLadderOfferData : DirectStoreConditionChecker
	{
		[SerializeField]
		private LadderOfferView ladderOfferView;

		public override bool IsActive()
		{
			return false;
		}
	}
}
