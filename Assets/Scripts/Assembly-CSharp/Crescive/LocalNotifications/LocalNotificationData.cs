using System;
using System.Collections.Generic;

namespace Crescive.LocalNotifications
{
	[Serializable]
	public class LocalNotificationData
	{
		public List<LocalNotificationSettings> NotificationDataList;

		public int MaxTotalNotificationCount;

		public int HighRankFallThreshold;

		public int LowRankFallTreshold;

		public LocalNotificationData(LocalNotificationData data)
		{
		}
	}
}
