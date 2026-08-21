using Crescive.DataService;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	[CreateAssetMenu(fileName = "ScheduledNotificationSettingsService", menuName = "Notifications/ScheduledNotificationSettingsService")]
	public class ScheduledNotificationSettingsService : DataReadService<ScheduledNotificationData>
	{
		protected override ScheduledNotificationData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(ScheduledNotificationData plainData)
		{
			return false;
		}
	}
}
