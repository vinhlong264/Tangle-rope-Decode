using PersistentSO;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	public class NotificationTimer : MonoBehaviour
	{
		[SerializeField]
		private PersistentIntVariable TotalNotificationRemainingAmount;

		[SerializeField]
		private PersistentIntVariable HeartNotificationRemainingAmount;

		[SerializeField]
		private PersistentIntVariable RankUpNotificationRemainingAmount;

		[SerializeField]
		private PersistentIntVariable RankDownNotificationRemainingAmount;

		[SerializeField]
		private PersistentIntVariable LeagueRemainingNotificationAmount;

		[SerializeField]
		private PersistentStringVariable LastRestartDate;

		[SerializeField]
		private LocalNotificationSettingsService localNotificationsService;

		private const int SecondsInOneDay = 86400;

		private void Start()
		{
		}

		private void OnNotificationSent(NotificationInfo info)
		{
		}

		private void RestartNotifications()
		{
		}

		private double RestartRemainingTime()
		{
			return 0.0;
		}
	}
}
