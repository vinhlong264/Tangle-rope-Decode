using PersistentSO;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	[CreateAssetMenu(fileName = "PersistentNotificationInfoList", menuName = "ScriptableObjects/Persistent/PersistentNotificationInfoList")]
	public class PersistentNotificationInfoList : PersistentListVariable<NotificationPair>
	{
		public void AddWithKey(string key, NotificationInfo info)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public NotificationInfo GetNotificationInfo(string key)
		{
			return default(NotificationInfo);
		}

		public void RemoveNotificationInfo(string key)
		{
		}

		public override NotificationPair GetItemCopy(NotificationPair item)
		{
			return default(NotificationPair);
		}
	}
}
