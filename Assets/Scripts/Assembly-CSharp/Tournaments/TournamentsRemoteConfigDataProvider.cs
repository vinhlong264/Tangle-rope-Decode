using Crescive.DataService;
using UnityEngine;

namespace Tournaments
{
	[CreateAssetMenu(fileName = "TournamentsSettingsRemoteConfigDataProvider", menuName = "Crescive/DataService/Tournament Remote")]
	public class TournamentsRemoteConfigDataProvider : RemoteConfigDataProvider<TournamentsSettings>
	{
		public override void Get(DataProviderGetCallback<TournamentsSettings> getCallback)
		{
		}
	}
}
