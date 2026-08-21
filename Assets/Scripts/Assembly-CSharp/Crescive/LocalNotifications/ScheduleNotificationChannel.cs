using System;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	[CreateAssetMenu(fileName = "ScheduledNotificationChannel", menuName = "Notifications/Scheduled Notification Channel")]
	public class ScheduleNotificationChannel : BaseNotificationChannel
	{
		public void ScheduleNotification(string headings, string contents, DateTime date, string notificationID, string smallIconKey = "icon_0", string largeIconKey = "default")
		{
		}
	}
}
