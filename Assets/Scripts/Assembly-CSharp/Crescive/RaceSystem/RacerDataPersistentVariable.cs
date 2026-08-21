using PersistentSO;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RacerDataPersistentVariable", menuName = "Crescive/Race System/Persistent/RacerDataPersistentVariable")]
	public class RacerDataPersistentVariable : PersistentVariable<RacerData>
	{
		public override RacerData GetCopy(RacerData value)
		{
			return null;
		}
	}
}
