using System;
using System.Collections.Generic;

namespace Crescive.LocalNotifications
{
	[Serializable]
	public class ScheduledNotificationData
	{
		public List<ScheduledNotificationSettings> NotificationDataList;

		public bool IsEnabled;

		public ScheduledNotificationData(ScheduledNotificationData data)
		{
		}
	}
}
