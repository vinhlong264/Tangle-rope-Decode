using UnityAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Can Show Dynamic Quest Golden Pass Intro Condition", menuName = "Crescive/Monetization Features/Dynamic Quest/Condition/Can Show Dynamic Quest Golden Pass Intro Condition")]
	public class CanShowDynamicQuestGoldenPassIntroCondition : AtomCondition
	{
		[SerializeField]
		private DynamicQuestSystem system;

		public override bool Call()
		{
			return false;
		}
	}
}
