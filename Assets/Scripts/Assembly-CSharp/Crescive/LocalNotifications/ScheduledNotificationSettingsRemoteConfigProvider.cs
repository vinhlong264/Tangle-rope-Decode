using Crescive.DataService;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	[CreateAssetMenu(fileName = "ScheduledNotificationSettingsRemoteConfigProvider", menuName = "Notifications/Scheduled Notification Settings Remote Config Provider")]
	public class ScheduledNotificationSettingsRemoteConfigProvider : RemoteConfigDataProvider<ScheduledNotificationData>
	{
	}
}
