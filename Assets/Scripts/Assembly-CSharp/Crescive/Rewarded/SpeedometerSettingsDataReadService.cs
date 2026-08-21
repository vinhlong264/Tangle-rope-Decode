using Crescive.DataService;
using UnityEngine;

namespace Crescive.Rewarded
{
	[CreateAssetMenu(fileName = "SpeedometerSettingsDataReadService", menuName = "Crescive/Speedometer/SpeedometerSettingsDataReadService")]
	public class SpeedometerSettingsDataReadService : DataReadService<SpeedometerSettingsData>
	{
		protected override SpeedometerSettingsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(SpeedometerSettingsData plainData)
		{
			return false;
		}
	}
}
