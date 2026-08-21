using Crescive.DataService;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RaceDataReadService", menuName = "Crescive/Race System/Service/Read/RaceDataReadService")]
	public class RaceDataReadService : DataReadService<RaceData>
	{
		protected override RaceData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(RaceData plainData)
		{
			return false;
		}
	}
}
