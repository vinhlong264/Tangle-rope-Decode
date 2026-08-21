using Crescive.DataService;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RaceStatusDataReadService", menuName = "Crescive/Race System/Service/Read/RaceStatusDataReadService")]
	public class RaceStatusDataReadService : DataReadService<RaceStatusData>
	{
		protected override RaceStatusData GetInitialDataCopy()
		{
			return default(RaceStatusData);
		}

		protected override bool IsDataValid(RaceStatusData plainData)
		{
			return false;
		}
	}
}
