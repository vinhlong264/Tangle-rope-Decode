using System;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	public abstract class BaseNotificationChannel : ScriptableObject
	{
		[SerializeField]
		protected PersistentNotificationInfoList notificationInfoList;

		public Action<NotificationInfo> OnNotificationScheduled;

		protected void AndroidSendNotificationWithDelayInSeconds(string title, string text, double delayInSeconds, int id, string smallIconKey = "icon_0", string largeIconKey = "default")
		{
		}

		protected void AndroidSendNotificationWithDate(string title, string text, DateTime date, int id, string smallIconKey = "icon_0", string largeIconKey = "default")
		{
		}

		protected void AndroidDeleteNotification(int id)
		{
		}

		protected void IOSSendNotificationWithDelayInSeconds(string title, string body, string subtitle, int fireTimeInSeconds, int id)
		{
		}

		protected void IOSSendNotificationWithDate(string title, string body, string subtitle, DateTime date, int id)
		{
		}

		protected void IOSDeleteNotification(int id)
		{
		}
	}
}
