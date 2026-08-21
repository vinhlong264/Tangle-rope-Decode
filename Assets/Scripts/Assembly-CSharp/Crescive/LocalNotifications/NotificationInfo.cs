using System;

namespace Crescive.LocalNotifications
{
	[Serializable]
	public struct NotificationInfo
	{
		public string NotificationID;

		public string ScheduledTime;

		public NotificationInfo(string notificationID, string scheduledTime)
		{
			NotificationID = null;
			ScheduledTime = null;
		}
	}
}
