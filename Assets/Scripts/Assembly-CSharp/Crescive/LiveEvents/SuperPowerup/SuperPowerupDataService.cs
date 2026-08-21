using Crescive.DataService;
using UnityEngine;

namespace Crescive.LiveEvents.SuperPowerup
{
	[CreateAssetMenu(fileName = "SuperPowerupDataService", menuName = "Crescive/SuperPowerup/SuperPowerupDataService")]
	public class SuperPowerupDataService : DataReadService<ConsecutiveWinSettings>
	{
		protected override ConsecutiveWinSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(ConsecutiveWinSettings plainData)
		{
			return false;
		}
	}
}
