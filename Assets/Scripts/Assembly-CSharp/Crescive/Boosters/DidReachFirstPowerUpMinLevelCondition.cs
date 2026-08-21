using Crescive.PowerUps;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Boosters
{
	[CreateAssetMenu(fileName = "Did Reach First Power Up Min Level Condition", menuName = "Crescive/Power Ups/Conditions/Did Reach First Power Up Min Level Condition")]
	public class DidReachFirstPowerUpMinLevelCondition : AtomCondition
	{
		[SerializeField]
		private PowerUpSystem powerUpSystem;

		public override bool Call()
		{
			return false;
		}
	}
}
