using Crescive.DataService;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RacerDataReadService", menuName = "Crescive/Race System/Service/Read/RacerDataReadService")]
	public class RacerDataReadService : DataReadService<RacerData>
	{
		protected override RacerData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(RacerData plainData)
		{
			return false;
		}
	}
}
