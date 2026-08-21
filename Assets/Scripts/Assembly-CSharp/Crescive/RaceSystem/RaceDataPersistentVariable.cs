using PersistentSO;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RaceDataPersistentVariable", menuName = "Crescive/Race System/Persistent/RaceDataPersistentVariable")]
	public class RaceDataPersistentVariable : PersistentVariable<RaceData>
	{
		public override RaceData GetCopy(RaceData value)
		{
			return null;
		}
	}
}
