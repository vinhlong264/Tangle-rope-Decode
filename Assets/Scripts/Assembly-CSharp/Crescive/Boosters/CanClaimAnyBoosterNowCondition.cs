using UnityAtoms;
using UnityEngine;

namespace Crescive.Boosters
{
	[CreateAssetMenu(fileName = "Can Claim Any Booster Now Condition", menuName = "Crescive/Boosters/Conditions/Can Claim Any Booster Now Condition")]
	public class CanClaimAnyBoosterNowCondition : AtomCondition
	{
		[SerializeField]
		private BoosterSystem boosterSystem;

		public override bool Call()
		{
			return false;
		}
	}
}
