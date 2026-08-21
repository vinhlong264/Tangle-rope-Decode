using Crescive.DataService;
using UnityEngine;

namespace SegmentedOffers
{
	[CreateAssetMenu(fileName = " LevelsDataRemoteConfigProvider", menuName = "Crescive/Levels Data Service/DataService/Levels Data Remote")]
	public class LevelsDataRemoteConfigProvider : RemoteConfigDataProvider<LevelsSettings>
	{
		public override void Get(DataProviderGetCallback<LevelsSettings> getCallback)
		{
		}
	}
}
