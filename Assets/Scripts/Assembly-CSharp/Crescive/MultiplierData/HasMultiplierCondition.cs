using UnityAtoms;
using UnityEngine;

namespace Crescive.MultiplierData
{
	[CreateAssetMenu(fileName = "New Multiplier Property", menuName = "Crescive/GameData/Multiplier/Has Multiplier Condition")]
	public class HasMultiplierCondition : AtomCondition
	{
		[SerializeField]
		private PersistentMultipliers persistentMultipliers;

		[SerializeField]
		private MultiplierArgs args;

		public override bool Call()
		{
			return false;
		}
	}
}
