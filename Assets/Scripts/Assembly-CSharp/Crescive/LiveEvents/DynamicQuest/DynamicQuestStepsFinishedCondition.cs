using UnityAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Dynamic Quest Steps Finished Condition", menuName = "Crescive/Monetization Features/Dynamic Quest/Condition/Dynamic Quest Steps Finished Condition")]
	public class DynamicQuestStepsFinishedCondition : AtomCondition
	{
		[SerializeField]
		private DynamicQuestSystem system;

		public override bool Call()
		{
			return false;
		}
	}
}
