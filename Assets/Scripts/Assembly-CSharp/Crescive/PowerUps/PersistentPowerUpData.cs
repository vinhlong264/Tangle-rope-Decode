using PersistentSO;
using UnityEngine;

namespace Crescive.PowerUps
{
	[CreateAssetMenu(fileName = "Persistent Power Up Data", menuName = "Crescive/Power Ups/Persistent/Persistent Power Up Data")]
	public class PersistentPowerUpData : PersistentVariable<PowerUpSaveData>
	{
		public override PowerUpSaveData GetCopy(PowerUpSaveData value)
		{
			return null;
		}
	}
}
