using Crescive.DataService;
using Crescive.LiveEvents.SuperPowerup;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[CreateAssetMenu(fileName = "SuperPowerupRemoteConfigDataProvider", menuName = "Crescive/SuperPowerup/SuperPowerupRemoteConfigDataProvider")]
	public class SuperPowerupRemoteConfigDataProvider : RemoteConfigDataProvider<ConsecutiveWinSettings>
	{
	}
}
