using System;
using System.Collections.Generic;

namespace Crescive.LocalNotifications
{
	[Serializable]
	public class ScheduledNotificationSettings
	{
		public List<LanguageTextPair> LanguageTextPairList;

		public string ScheduleDate;

		public bool ShouldRepeat;

		public string NotificationID;

		public bool ThisNotiIsEnabled;

		public ScheduledNotificationSettings(List<LanguageTextPair> languageTextPairList, string scheduleDate, bool shouldRepeat, string notificationID, bool thisNotiIsEnabled)
		{
		}

		public ScheduledNotificationSettings(ScheduledNotificationSettings settings)
		{
		}
	}
}
