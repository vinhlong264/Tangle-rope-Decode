using PersistentSO;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "NpcRacersDataPersistentVariable", menuName = "Crescive/Race System/Persistent/NpcRacersDataPersistentVariable")]
	public class NpcRacersDataPersistentVariable : PersistentVariable<NpcRacersData>
	{
		public override NpcRacersData GetCopy(NpcRacersData value)
		{
			return null;
		}
	}
}
