using Crescive.DataService;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RaceSettingsDataReadService", menuName = "Crescive/Race System/Service/Read/RaceSettingsDataReadService")]
	public class RaceSettingsDataReadService : DataReadService<RaceSettingsData>
	{
		protected override RaceSettingsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(RaceSettingsData plainData)
		{
			return false;
		}
	}
}
