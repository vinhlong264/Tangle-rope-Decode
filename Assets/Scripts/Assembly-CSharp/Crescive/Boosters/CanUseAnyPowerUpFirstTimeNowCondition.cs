using Crescive.PowerUps;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Boosters
{
	[CreateAssetMenu(fileName = "Can Use Any Power Up First Time Now Condition", menuName = "Crescive/Power Ups/Conditions/Can Use Any Power Up First Time Now Condition")]
	public class CanUseAnyPowerUpFirstTimeNowCondition : AtomCondition
	{
		[SerializeField]
		private PowerUpSystem powerUpSystem;

		public override bool Call()
		{
			return false;
		}
	}
}
