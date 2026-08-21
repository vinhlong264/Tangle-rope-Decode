using Crescive.DataService;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/DataService/Remote Config Provider", fileName = "IAPRemoteConfigProvider")]
	public class IAPRemoteConfigProvider : RemoteConfigCompositeDataProvider<IAPData>
	{
	}
}
