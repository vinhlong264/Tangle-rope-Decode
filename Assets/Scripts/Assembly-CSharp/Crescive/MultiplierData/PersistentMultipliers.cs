using PersistentSO;
using UnityEngine;

namespace Crescive.MultiplierData
{
	[CreateAssetMenu(fileName = "New Multipliers", menuName = "Crescive/GameData/Multiplier/PersistentMultipliers")]
	public class PersistentMultipliers : PersistentListVariable<MultiplierData>
	{
		public override MultiplierData GetItemCopy(MultiplierData item)
		{
			return null;
		}

		public void AddOrChange(MultiplierArgs args)
		{
		}

		public void Remove(MultiplierArgs args)
		{
		}

		public bool HasMultiplier(string id)
		{
			return false;
		}
	}
}
