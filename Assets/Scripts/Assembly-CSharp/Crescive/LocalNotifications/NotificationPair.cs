using System;

namespace Crescive.LocalNotifications
{
	[Serializable]
	public struct NotificationPair
	{
		public string Key;

		public NotificationInfo Info;

		public NotificationPair(string key, NotificationInfo info)
		{
			Key = null;
			Info = default(NotificationInfo);
		}

		public NotificationPair(NotificationPair item)
		{
			Key = null;
			Info = default(NotificationInfo);
		}
	}
}
