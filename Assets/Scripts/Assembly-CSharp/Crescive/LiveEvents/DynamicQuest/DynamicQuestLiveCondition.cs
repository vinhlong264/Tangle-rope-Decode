using UnityAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Dynamic Quest Live Condition", menuName = "Crescive/Monetization Features/Dynamic Quest/Condition/Dynamic Quest Live Condition")]
	public class DynamicQuestLiveCondition : AtomCondition
	{
		[SerializeField]
		private DynamicQuestSystem system;

		public override bool Call()
		{
			return false;
		}
	}
}
