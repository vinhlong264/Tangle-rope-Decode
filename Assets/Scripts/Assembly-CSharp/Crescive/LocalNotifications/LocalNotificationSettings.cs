using System;
using System.Collections.Generic;

namespace Crescive.LocalNotifications
{
	[Serializable]
	public class LocalNotificationSettings
	{
		public bool IsEnabled;

		public int MaxNotificationLimit;

		public int StartHour;

		public int EndHour;

		public List<LanguageTextPair> LanguageTextPairList;

		public LocalNotificationSettings(bool isEnabled, int maxNotificationLimit, int startHour, int endHour, List<LanguageTextPair> languageTextPairList)
		{
		}

		public LocalNotificationSettings(LocalNotificationSettings settings)
		{
		}
	}
}
