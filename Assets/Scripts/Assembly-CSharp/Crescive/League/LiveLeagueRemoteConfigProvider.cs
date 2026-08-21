using Crescive.DataService;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "LiveLeagueRemoteConfigProvider", menuName = "Crescive/League/LiveLeagueRemoteConfigProvider", order = 0)]
	public class LiveLeagueRemoteConfigProvider : RemoteConfigReferenceKeyDataProvider<LiveLeagueSettings>
	{
	}
}
