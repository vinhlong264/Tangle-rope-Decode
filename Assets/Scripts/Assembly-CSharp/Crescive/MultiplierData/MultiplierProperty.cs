using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.MultiplierData
{
	[CreateAssetMenu(fileName = "New Multiplier Property", menuName = "Crescive/GameData/Multiplier/MultiplierProperty")]
	public class MultiplierProperty : FloatScriptableProperty
	{
		[SerializeField]
		private PersistentMultipliers persistentMultipliers;

		[SerializeField]
		private MultiplierArgs multiplierArgs;

		public bool IsActive => false;

		protected override float GetValue()
		{
			return 0f;
		}
	}
}
