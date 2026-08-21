using UnityAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Must Claim Dynamic Quest Golden Pass Condition", menuName = "Crescive/Monetization Features/Dynamic Quest/Condition/Must Claim Dynamic Quest Golden Pass Condition")]
	public class MustClaimDynamicQuestGoldenPassCondition : AtomCondition
	{
		[SerializeField]
		private DynamicQuestSystem system;

		public override bool Call()
		{
			return false;
		}
	}
}
