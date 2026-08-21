using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	public class DailyNotificationScheduler : MonoBehaviour
	{
		[SerializeField]
		private ScheduleNotificationChannel channel;

		[SerializeField]
		private ScheduledNotificationSettingsService settingsService;

		[SerializeField]
		protected PersistentNotificationInfoList notificationInfoList;

		private List<ScheduledNotificationSettings> repeatingDataList;

		private List<ScheduledNotificationSettings> oneShotDataList;

		private List<LanguageTextPair> languageTextPairList;

		private int systemLanguageIndex;

		private string systemLanguage;

		private void Start()
		{
		}

		private void InitializeScheduleNotifications()
		{
		}

		private DateTime StartDate(out int postedNotificationCount)
		{
			postedNotificationCount = default(int);
			return default(DateTime);
		}

		private void InitializeNotificationData()
		{
		}

		private void ScheduleRepeatingNotifications()
		{
		}

		private void ScheduleOneShotNotifications()
		{
		}

		private int GetSystemLanguageIndex()
		{
			return 0;
		}

		private string GetSystemLanguage()
		{
			return null;
		}
	}
}
