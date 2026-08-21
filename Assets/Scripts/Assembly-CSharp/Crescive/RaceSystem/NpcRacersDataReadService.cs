using Crescive.DataService;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "NpcRacersDataReadService", menuName = "Crescive/Race System/Service/Read/NpcRacersDataReadService")]
	public class NpcRacersDataReadService : DataReadService<NpcRacersData>
	{
		protected override NpcRacersData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(NpcRacersData plainData)
		{
			return false;
		}
	}
}
