using Crescive.DataService;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(menuName = "Crescive/Levels/DataService/Levels Settings Remote Config Provider", fileName = "LevelsSettingsRemoteConfigProvider")]
	public class LevelsSettingsRemoteConfigProvider : RemoteConfigReferenceKeyDataProvider<LevelsSettingsData>
	{
	}
}
