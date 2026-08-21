using Crescive.DataService;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	[CreateAssetMenu(fileName = "LocalNotificationSettingsService", menuName = "Notifications/LocalNotificationSettingsService")]
	public class LocalNotificationSettingsService : DataReadService<LocalNotificationData>
	{
		protected override LocalNotificationData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LocalNotificationData plainData)
		{
			return false;
		}
	}
}
