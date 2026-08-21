using UnityAtoms;
using UnityEngine;

namespace DynamicQuestTime
{
	[CreateAssetMenu(fileName = "Dynamic Quest Time Live Condition", menuName = "Crescive/Monetization Features/Dynamic Quest Time/Condition/Dynamic Quest Time Live Condition")]
	public class DynamicQuestTimeLiveCondition : AtomCondition
	{
		public override bool Call()
		{
			return false;
		}
	}
}
