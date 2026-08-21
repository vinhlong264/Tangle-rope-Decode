using PersistentSO;
using UnityEngine;

namespace Crescive.LiveEvents.SuperPowerup
{
	[CreateAssetMenu(fileName = "PersistentSuperPowerupData", menuName = "Crescive/SuperPowerup/PersistentSuperPowerupData")]
	public class PersistentConsecutiveWinSaveData : PersistentVariable<ConsecutiveWinSaveData>
	{
		public override ConsecutiveWinSaveData GetCopy(ConsecutiveWinSaveData value)
		{
			return null;
		}
	}
}
