using Crescive.DataService;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	[CreateAssetMenu(fileName = "LocalNotificationSettingsRemoteConfigProvider", menuName = "Notifications/Local Notification Settings Remote Config Provider")]
	public class LocalNotificationSettingsRemoteConfigProvider : RemoteConfigDataProvider<LocalNotificationData>
	{
	}
}
