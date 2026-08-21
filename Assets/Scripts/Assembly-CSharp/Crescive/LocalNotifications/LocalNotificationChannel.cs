using System;
using PersistentSO;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	[CreateAssetMenu(fileName = "LocalNotificationChannel", menuName = "Notifications/Local Notification Channel")]
	public class LocalNotificationChannel : BaseNotificationChannel
	{
		[SerializeField]
		private PersistentIntVariable customNotificationRemainingAmount;

		[SerializeField]
		private PersistentIntVariable totalNotificationRemainingAmount;

		private bool IsNotificationAvailable()
		{
			return false;
		}

		private void ReduceNotificationCount()
		{
		}

		private double GetActualDelay(int startHour, int endHour, double delay)
		{
			return 0.0;
		}

		private void PostAction(string headings, string contents, double actualDelay, string notificationID, string smallIconKey, string largeIconKey)
		{
		}

		private void PostAction(string headings, string contents, DateTime date, string notificationID, string smallIconKey, string largeIconKey)
		{
		}

		public void PushNotification(string headings, string contents, double delay, string notificationID, int startHour, int endHour, string smallIconKey = "default", string largeIconKey = "default")
		{
		}

		public void PushNotification(string headings, string contents, DateTime date, string notificationID, int startHour, int endHour, string smallIconKey = "default", string largeIconKey = "default")
		{
		}

		public void DeleteNotification(string notificationID)
		{
		}
	}
}
